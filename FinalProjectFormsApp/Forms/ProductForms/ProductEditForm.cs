using DataAccess.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.Abstracts;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.ProductForms
{
    public partial class ProductEditForm : Form
    {
        private IProductService _productService;

        public LogisticsForm LogisticsFormInstance { get; set; }
        public User CurrentUser { get; set; }
        public Product SelectedProduct { get; set; }

        public ProductEditForm(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            productName.Text = SelectedProduct.Name;
            price.Value = SelectedProduct.Price;
            weight.Value = SelectedProduct.Weight;
            stock.Value = SelectedProduct.StockQuantity;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            SelectedProduct.Name = productName.Text;
            SelectedProduct.Price = price.Value;
            SelectedProduct.Weight = weight.Value;
            SelectedProduct.StockQuantity = (int) stock.Value;

            _productService.Edit(SelectedProduct);
            LogisticsFormInstance.UpdateProductsDataGridViewDataSource();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete product ?.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                _productService.Delete(SelectedProduct);
                LogisticsFormInstance.UpdateProductsDataGridViewDataSource();
                this.Close();
            }
        }
    }
}
