using DataAccess.Dtos;
using DataAccess.Entities;
using FinalProjectFormsApp.Forms.OrderItemForms;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.OrderForms
{
    public partial class OrderEditForm : Form, IOrderForm
    {
        private Timer timer;
        DateTime currentDate;
        private IProductService _productService;
        private IVehicleService _vehicleService;
        private IOrderService _orderService;
        private IOrderItemService _orderItemService;

        public User CurrentUser { get; set; }
        public LogisticsForm LogisticsFormInstance { get; set; }
        public OrderDetailDto SelectedOrder { get; set; }

        public OrderEditForm(IProductService productService, IVehicleService vehicleService, IOrderService orderService, IOrderItemService orderItemService)
        {
            InitializeComponent();
            timer = new Timer();
            _productService = productService;
            _vehicleService = vehicleService;
            _orderService = orderService;
            _orderItemService = orderItemService;
        }

        private void OrderEditForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            delete.Visible = CurrentUser.IsManager;

            RefreshFormContent();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            SelectedOrder.TotalWeight = _orderService.GetById(SelectedOrder.OrderId).TotalWeight;
            SelectedOrder.DestinationAddress = destinationAddress.Text;
            

            var selectedStatus = (OrderStatus)status.SelectedValue;
            Vehicle currentVehicle;
            switch (selectedStatus)
            {
                case OrderStatus.Pending:
                    // Pending
                    SelectedOrder.OrderStatus = OrderStatus.Pending;

                    if ((int)vehicle.SelectedValue != _orderService.GetById(SelectedOrder.OrderId).VehicleId)
                    {
                        Vehicle oldVehicle = _vehicleService.GetById(_orderService.GetById(SelectedOrder.OrderId).VehicleId);
                        oldVehicle.IsAvailable = true;
                        _vehicleService.Update(oldVehicle);
                    }

                    Vehicle _vehicle = _vehicleService.GetById((int) vehicle.SelectedValue);
                    var result = _vehicle.Capacity - SelectedOrder.TotalWeight;
                    if (result >= 0)
                    {
                        SelectedOrder.VehicleId = (int)vehicle.SelectedValue;
                    } else
                    {
                        MessageBox.Show("total weight exceeds the vehicle's capacity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Vehicle newVehicle = _vehicleService.GetById(SelectedOrder.VehicleId);
                    newVehicle.IsAvailable = false;
                    _vehicleService.Update(newVehicle);
                    if (SelectedOrder.ShippedDate < currentDate)
                    {
                        MessageBox.Show("order is on the way", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
                case OrderStatus.Shipped:
                    // Shipped
                    SelectedOrder.OrderStatus = OrderStatus.Shipped;

                    SelectedOrder.ShippedDate = shippedDate.Value;
                    break;
                case OrderStatus.Delivered:
                    // Delivered
                    SelectedOrder.OrderStatus = OrderStatus.Delivered;

                    if (SelectedOrder.ShippedDate.HasValue)
                    {
                        SelectedOrder.DeliveredDate = deliveredDate.Value;

                        if (SelectedOrder.DeliveredDate <= currentDate)
                        {
                            currentVehicle = _vehicleService.GetById(SelectedOrder.VehicleId);
                            currentVehicle.IsAvailable = true;
                            _vehicleService.Update(currentVehicle);
                        } else if (SelectedOrder.DeliveredDate > currentDate)
                        {
                            currentVehicle = _vehicleService.GetById(SelectedOrder.VehicleId);
                            currentVehicle.IsAvailable = false;
                            _vehicleService.Update(currentVehicle);
                        }
                    }
                    break;
                case OrderStatus.Canceled:
                    // Canceled
                    SelectedOrder.OrderStatus = OrderStatus.Delivered;
                    DialogResult dialogResult = MessageBox.Show("Do you want to cancel order ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SelectedOrder.CanceledDate = DateTime.Now;
                        currentVehicle = _vehicleService.GetById(SelectedOrder.VehicleId);
                        currentVehicle.IsAvailable = true;
                        _vehicleService.Update(currentVehicle);

                        List<OrderItem> items = _orderItemService.GetListByOrderId(SelectedOrder.OrderId);

                        foreach (OrderItem item in items)
                        {
                            Product product = _productService.GetById(item.ProductId);
                            product.StockQuantity += item.ProductQuantity;
                            _productService.Edit(product);
                        }

                        HandleSetAllFieldsFalse();
                    }
                    break;
            }

            _orderService.Edit(MappingOrderDetailDtoToOrder(SelectedOrder));

            LogisticsFormInstance.UpdateOrdersDataGridViewDataSource();
            LogisticsFormInstance.UpdateProductsDataGridViewDataSource();
            LogisticsFormInstance.UpdateVehiclesDataGridViewDataSource();

            RefreshFormContent();

            UpdateProgressBar();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete order ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Vehicle oldVehicle = _vehicleService.GetById(_orderService.GetById(SelectedOrder.OrderId).VehicleId);
                oldVehicle.IsAvailable = true;
                _vehicleService.Update(oldVehicle);

                List<OrderItem> orderItems = _orderItemService.GetListByOrderId(SelectedOrder.OrderId);

                foreach (OrderItem item in orderItems)
                {
                    Product product = _productService.GetById(item.ProductId);
                    product.StockQuantity += item.ProductQuantity;

                    _productService.Edit(product);
                    _orderItemService.Delete(item);
                }

                _orderService.Delete(MappingOrderDetailDtoToOrder(SelectedOrder));

                LogisticsFormInstance.UpdateOrdersDataGridViewDataSource();
                LogisticsFormInstance.UpdateProductsDataGridViewDataSource();
                LogisticsFormInstance.UpdateVehiclesDataGridViewDataSource();

                this.Close();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OrderItemCreateForm orderItemCreateForm = Program.GetService<OrderItemCreateForm>();
            orderItemCreateForm.OrderFormInstance = this;
            orderItemCreateForm.LogisticsFormInstance = LogisticsFormInstance;
            orderItemCreateForm.Order = _orderService.GetById(SelectedOrder.OrderId);
            orderItemCreateForm.Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                int selectedOrderItemId = (int) listBox.SelectedValue;
                OrderItem orderItem = _orderItemService.GetById(selectedOrderItemId);

                Product product = _productService.GetById(orderItem.ProductId);
                product.StockQuantity += orderItem.ProductQuantity;

                Order order = _orderService.GetById(SelectedOrder.OrderId);
                order.TotalWeight -= (product.Weight * orderItem.ProductQuantity);

                _orderService.Edit(order);
                _productService.Edit(product);
                _orderItemService.Delete(orderItem);

                UpdateListBox();
                UpdateProgressBar();

                LogisticsFormInstance.UpdateOrdersDataGridViewDataSource();
                LogisticsFormInstance.UpdateProductsDataGridViewDataSource();
                LogisticsFormInstance.UpdateVehiclesDataGridViewDataSource();
            }
        }

        private void Vehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle _vehicle = _vehicleService.GetById(SelectedOrder.VehicleId);
            var result = _vehicle.Capacity - SelectedOrder.TotalWeight;
            if (result <= 0)
            {
                MessageBox.Show("total weight exceeds the vehicle's capacity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                vehicle.SelectedValue = SelectedOrder.VehicleId;
            }
        }

        public void UpdateProgressBar()
        {
            Vehicle vehicle = _vehicleService.GetById(_orderService.GetById(SelectedOrder.OrderId).VehicleId);
            ratio.Text = $"{_orderService.GetById(SelectedOrder.OrderId).TotalWeight} / {vehicle.Capacity}";
            var result = vehicle.Capacity - SelectedOrder.TotalWeight;
            if (result >= 0)
            {
                progressBar.Value = (int)((_orderService.GetById(SelectedOrder.OrderId).TotalWeight + 1) * 100 / vehicle.Capacity);
            }
        }

        public void UpdateListBox()
        {
            List<OrderItem> items = _orderItemService.GetListByOrderId(SelectedOrder.OrderId);
            List<ItemListBoxRow> itemDetailDtoList = new List<ItemListBoxRow>();

            foreach (OrderItem item in items)
            {
                Product product = _productService.GetById(item.ProductId);
                itemDetailDtoList.Add(new ItemListBoxRow()
                {
                    Id = item.Id,
                    DisplayText = $"{product.Name}-({item.ProductQuantity})",
                });
            }

            listBox.ValueMember = "Id";
            listBox.DisplayMember = "DisplayText";
            listBox.DataSource = itemDetailDtoList;
        }

        private Order MappingOrderDetailDtoToOrder(OrderDetailDto dto)
        {
            Order order = new Order();
            order.Id = dto.OrderId;
            order.VehicleId = dto.VehicleId;
            order.PendingDate = dto.PendingDate;
            order.ShippedDate = dto.ShippedDate;
            order.DeliveredDate = dto.DeliveredDate;
            order.CanceledDate = dto.CanceledDate;
            order.DestinationAddress = dto.DestinationAddress;
            order.TotalWeight = dto.TotalWeight;
            order.OrderStatus = dto.OrderStatus;

            return order;
        }

        private void HandleItemsFieldsEnabled(bool enabled)
        {
            listBox.Enabled = true;
            add.Enabled = enabled;
            remove.Enabled = enabled;
        }

        private void HandleSetAllFieldsFalse()
        {
            destinationAddress.Enabled = false;
            vehicle.Enabled = false;
            status.Enabled = false;
            pendingDate.Enabled = false;
            shippedDate.Enabled = false;
            deliveredDate.Enabled = false;
            canceledDate.Enabled = false;
            HandleItemsFieldsEnabled(false);

            edit.Visible = false;
        }

        private void RefreshFormContent()
        {

            this.Text = SelectedOrder.OrderId.ToString();
            status.DataSource = Enum.GetValues(typeof(OrderStatus));

            vehicle.ValueMember = "Id";
            vehicle.DisplayMember = "Plate";
            vehicle.DataSource = _vehicleService.GetAllAvailable(_orderService.GetById(SelectedOrder.OrderId));

            vehicle.SelectedValue = SelectedOrder.VehicleId;
            destinationAddress.Text = SelectedOrder.DestinationAddress;
            status.SelectedItem = SelectedOrder.OrderStatus;


            if (SelectedOrder.PendingDate.HasValue)
            {
                pendingDate.Value = SelectedOrder.PendingDate.Value;
                shippedDate.MinDate = pendingDate.Value;
            }

            if (SelectedOrder.ShippedDate.HasValue)
            {
                shippedDate.Value = SelectedOrder.ShippedDate.Value;
                deliveredDate.MinDate = shippedDate.Value;
            }

            if (SelectedOrder.DeliveredDate.HasValue)
            {
                deliveredDate.Value = SelectedOrder.DeliveredDate.Value;
            }

            if (SelectedOrder.CanceledDate.HasValue)
            {
                canceledDate.Value = SelectedOrder.CanceledDate.Value;
                HandleSetAllFieldsFalse();
            }

            vehicle.Enabled = (SelectedOrder.OrderStatus == OrderStatus.Pending);

            HandleItemsFieldsEnabled(SelectedOrder.OrderStatus == OrderStatus.Pending);

            pendingDate.Enabled = false;
            shippedDate.Enabled = (SelectedOrder.OrderStatus == OrderStatus.Shipped);
            deliveredDate.Enabled = (SelectedOrder.OrderStatus == OrderStatus.Delivered && SelectedOrder.ShippedDate.HasValue);
            canceledDate.Enabled = false;

            UpdateListBox();
            UpdateProgressBar();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            currentDateLabel.Text = currentDate.ToString();
        }
    }
}
