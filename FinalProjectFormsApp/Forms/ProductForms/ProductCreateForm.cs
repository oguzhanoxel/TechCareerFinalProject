using DataAccess.Entities;
using Services.Services.Abstracts;
using System;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.UserForms
{
    public partial class ProductCreateForm : Form
    {
        private IProductService _productService;

        public User CurrentUser { get; set; }
        public LogisticsForm LogisticsFormInstance { get; set; }
        public ProductCreateForm(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = productName.Text;
            product.Price = price.Value;
            product.Weight = weight.Value;
            product.StockQuantity = (int) stock.Value;

            _productService.Add(product);
            LogisticsFormInstance.UpdateProductsDataGridViewDataSource();
            this.Close();
        }
    }
}
