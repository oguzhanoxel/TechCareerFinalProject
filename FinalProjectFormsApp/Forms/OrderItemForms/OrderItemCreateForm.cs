using DataAccess.Entities;
using FinalProjectFormsApp.Forms.OrderForms;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.OrderItemForms
{
    public partial class OrderItemCreateForm : Form
    {
        private IProductService _productService;
        private IOrderService _orderService;
        private IOrderItemService _orderItemService;
        private IVehicleService _vehicleService;

        public Order Order { get; set; }
        public IOrderForm OrderFormInstance { get; set; }
        public LogisticsForm LogisticsFormInstance { get; set; }

        public OrderItemCreateForm(IProductService productService, IOrderService orderService, IOrderItemService orderItemService, IVehicleService vehicleService)
        {
            InitializeComponent();
            _productService = productService;
            _orderService = orderService;
            _orderItemService = orderItemService;
            _vehicleService = vehicleService;
        }

        private void OrderItemCreateForm_Load(object sender, EventArgs e)
        {
            List<Product> products = _productService.GetList(p => p.StockQuantity != 0);
            productsComboBox.ValueMember = "Id";
            productsComboBox.DisplayMember = "Name";
            productsComboBox.DataSource = products;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = _vehicleService.GetById(Order.VehicleId);
            var weightResult = vehicle.Capacity - (Order.TotalWeight + CalcWeight());

            Product _product = _productService.GetById((int)productsComboBox.SelectedValue);
            var stockResult = _product.StockQuantity - (int)numberOfProduct.Value;

            if (weightResult >= 0)
            {
                if (stockResult >= 0)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.OrderId = Order.Id;
                    orderItem.ProductId = (int) productsComboBox.SelectedValue;
                    orderItem.ProductQuantity = (int) numberOfProduct.Value;
                    _orderItemService.Add(orderItem);

                    Order.TotalWeight += CalcWeight();
                    _orderService.Edit(Order);

                    Product product = _productService.GetById((int)productsComboBox.SelectedValue);
                    product.StockQuantity = CalcResult();
                    _productService.Edit(product);

                    LogisticsFormInstance.UpdateOrdersDataGridViewDataSource();
                    LogisticsFormInstance.UpdateProductsDataGridViewDataSource();
                    LogisticsFormInstance.UpdateVehiclesDataGridViewDataSource();

                    OrderFormInstance.UpdateListBox();
                    OrderFormInstance.UpdateProgressBar();
                    this.Close();
                } else
                {
                    MessageBox.Show("More products than stock are entered", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else {
                MessageBox.Show("total weight exceeds the vehicle's capacity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProductsComboBox_SelectedIndexChange(object sender, EventArgs e)
        {
            Product product = _productService.GetById((int) productsComboBox.SelectedValue);

            calculatedWeight.Text = CalcWeight().ToString();
            currentStock.Text = product.StockQuantity.ToString();
        }

        private void NumberOfProduct_ValueChanged(object sender, EventArgs e)
        {
            calculatedWeight.Text = $"{Order.TotalWeight}+{CalcWeight()}";
            currentStock.Text = CalcResult().ToString();
        }

        private int CalcResult()
        {
            Product product = _productService.GetById((int)productsComboBox.SelectedValue);
            int _numberOfProduct = (int)numberOfProduct.Value;
            return ((int) product.StockQuantity - _numberOfProduct);
        }

        private decimal CalcWeight()
        {
            Product product = _productService.GetById((int)productsComboBox.SelectedValue);
            int _numberOfProduct = (int)numberOfProduct.Value;

            return product.Weight*_numberOfProduct;
        }
    }
}
