using DataAccess.Entities;
using FinalProjectFormsApp.Forms.OrderItemForms;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.OrderForms
{
    public partial class OrderCreateForm : Form, IOrderForm
    {
        private Order _createdOrder;
        private IVehicleService _vehicleService;
        private IProductService _productService;
        private IOrderService _orderService;
        private IOrderItemService _orderItemService;

        public User CurrentUser { get; set; }
        public LogisticsForm LogisticsFormInstance { get; set; }

        public OrderCreateForm(IVehicleService vehicleService, IProductService productService, IOrderService orderService, IOrderItemService orderItemService)
        {
            InitializeComponent();
            _vehicleService = vehicleService;
            _productService = productService;
            _orderService = orderService;
            _orderItemService = orderItemService;
        }

        private void OrderCreateForm_Load(object sender, EventArgs e)
        {
            vehicle.ValueMember = "Id";
            vehicle.DisplayMember = "Plate";
            vehicle.DataSource = _vehicleService.GetAllAvailable();
            
            create.Text = "Next";
            HandleItemsFieldsEnabled(false);
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (create.Text == "Next")
            {
                _createdOrder = new Order();
                _createdOrder.VehicleId = (int) vehicle.SelectedValue;
                _createdOrder.TotalWeight = 0;
                _createdOrder.PendingDate = DateTime.Now;
                _createdOrder.DestinationAddress = destinationAddress.Text;
                _createdOrder.OrderStatus = OrderStatus.Pending;

                Vehicle _vehicle = _vehicleService.GetById(_createdOrder.VehicleId);
                _vehicle.IsAvailable = false;

                _vehicleService.Update(_vehicle);
                _orderService.Add(_createdOrder);
                create.Text = "Create";

                UpdateProgressBar();
                HandleOrderFieldsEnabled(false);
                HandleItemsFieldsEnabled(true);
            } else if (create.Text == "Create") { 
                this.Close();
            }
            LogisticsFormInstance.UpdateOrdersDataGridViewDataSource();
            LogisticsFormInstance.UpdateProductsDataGridViewDataSource();
            LogisticsFormInstance.UpdateVehiclesDataGridViewDataSource();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            OrderItemCreateForm orderItemCreateForm = Program.GetService<OrderItemCreateForm>();
            orderItemCreateForm.OrderFormInstance = this;
            orderItemCreateForm.LogisticsFormInstance = LogisticsFormInstance;
            orderItemCreateForm.Order = _createdOrder;
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

                _createdOrder.TotalWeight -= (product.Weight * orderItem.ProductQuantity);

                _orderService.Edit(_createdOrder);
                _productService.Edit(product);
                _orderItemService.Delete(orderItem);
                
                UpdateListBox();
                UpdateProgressBar();

                LogisticsFormInstance.UpdateOrdersDataGridViewDataSource();
                LogisticsFormInstance.UpdateProductsDataGridViewDataSource();
                LogisticsFormInstance.UpdateVehiclesDataGridViewDataSource();
            }
        }

        private void HandleItemsFieldsEnabled(bool enabled)
        {
            listBox.Enabled = enabled;
            add.Enabled = enabled;
            remove.Enabled = enabled;
        }

        private void HandleOrderFieldsEnabled(bool enabled)
        {
            vehicle.Enabled = enabled;
            destinationAddress.Enabled = enabled;
        }

        public void UpdateProgressBar()
        {
            Vehicle vehicle = _vehicleService.GetById(_createdOrder.VehicleId);
            ratio.Text = $"{_createdOrder.TotalWeight} / {vehicle.Capacity}";
            progressBar.Value = (int)((_createdOrder.TotalWeight + 1) * 100 / vehicle.Capacity);
        }

        public void UpdateListBox()
        {
            List<OrderItem> items = _orderItemService.GetListByOrderId(_createdOrder.Id);
            List<ItemListBoxRow> itemDetailDtoList = new List<ItemListBoxRow>();
            
            foreach (OrderItem item in items)
            {
                Product product = _productService.GetById(item.ProductId);
                itemDetailDtoList.Add(new ItemListBoxRow() {
                    Id = item.Id,
                    DisplayText = $"{product.Name}-({item.ProductQuantity})",
                });
            }

            listBox.ValueMember = "Id";
            listBox.DisplayMember = "DisplayText";
            listBox.DataSource = itemDetailDtoList;
        }
    }
}
