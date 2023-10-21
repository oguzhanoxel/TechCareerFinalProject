using ClosedXML.Excel;
using DataAccess.Dtos;
using DataAccess.Entities;
using FinalProjectFormsApp.Forms.OrderForms;
using FinalProjectFormsApp.Forms.ProductForms;
using FinalProjectFormsApp.Forms.ReportForms;
using FinalProjectFormsApp.Forms.UserForms;
using FinalProjectFormsApp.Forms.VehicleForms;
using Services.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FinalProjectFormsApp
{
    public partial class LogisticsForm : Form
    {
        private IUserService _userService;
        private IProductService _productService;
        private IOrderService _orderService;
        private IVehicleService _vehicleService;
        private IReportService _reportService;

        public User CurrentUser { get; set; } = null;
        public LoginForm LoginFormInstance { get; set; }

        public LogisticsForm(IUserService userService, IProductService productService, IOrderService orderService, IVehicleService vehicleService, IReportService reportService)
        {
            InitializeComponent();
            _userService = userService;
            _productService = productService;
            _orderService = orderService;
            _vehicleService = vehicleService;
            _reportService = reportService;
        }

        private void LogisticsForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Welcome, {CurrentUser.FirstName} {CurrentUser.LastName} !";
            UpdateUsersDataGridViewDataSource();
            UpdateProductsDataGridViewDataSource();
            UpdateOrdersDataGridViewDataSource();
            UpdateVehiclesDataGridViewDataSource();
            UpdateReportsDataGridViewDataSource();

            HandleVisibleUsersDataGridViewColumns();
            HandleVisibleProductsDataGridViewColumns();
            HandleVisibleOrdersDataGridViewColumns();
            HandleVisibleReportsDataGridViewColumns();

            if (!CurrentUser.IsManager)
            {
                tabControl.TabPages.Remove(reportsPage);
            }

            exportUsersExcel.Visible = CurrentUser.IsManager;
            exportProductsExcel.Visible = CurrentUser.IsManager;
            exportOrdersExcel.Visible = CurrentUser.IsManager;
            exportVehiclesExcel.Visible = CurrentUser.IsManager;
            exportReportsExcel.Visible = CurrentUser.IsManager;

            createVehicleButton.Visible = CurrentUser.IsManager;
            createProductButton.Visible = CurrentUser.IsManager;
        }

        private void LogisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.LoginFormInstance.Show();
        }

        // Search Text KeyUp Start
        private void UserSearch_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateUsersDataGridViewDataSource(userSearch.Text);
        }

        private void ProductSearch_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateProductsDataGridViewDataSource(productSearch.Text);
        }

        private void OrderSearch_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateOrdersDataGridViewDataSource(orderSearch.Text);
        }

        private void VehicleSearch_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateVehiclesDataGridViewDataSource(vehicleSearch.Text);
        }
        // Search Text KeyUp End

        // Cell Content Double Click Start
        private void UsersDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = usersDataGridView.Rows[rowIndex];

            User selectedUser = selectedRow.DataBoundItem as User;
            UserEditForm userEditForm = Program.GetService<UserEditForm>();
            userEditForm.LogisticsFormInstance = this;
            userEditForm.CurrentUser = CurrentUser;
            userEditForm.User = selectedUser;
            userEditForm.Show();
        }

        private void ProductsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = productsDataGridView.Rows[rowIndex];

            if (CurrentUser.IsManager)
            {
                Product selectedProduct = selectedRow.DataBoundItem as Product;
                ProductEditForm productEditForm = Program.GetService<ProductEditForm>();
                productEditForm.LogisticsFormInstance = this;
                productEditForm.CurrentUser = CurrentUser;
                productEditForm.SelectedProduct = selectedProduct;
                productEditForm.Show();
            }
        }

        private void OrdersDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            
            if (rowIndex == -1)
            {
                return;
            }
            
            DataGridViewRow selectedRow = ordersDataGridView.Rows[rowIndex];

            OrderDetailDto selectedOrder = selectedRow.DataBoundItem as OrderDetailDto;
            OrderEditForm orderEditForm = Program.GetService<OrderEditForm>();
            orderEditForm.LogisticsFormInstance = this;
            orderEditForm.CurrentUser = CurrentUser;
            orderEditForm.SelectedOrder = selectedOrder;
            orderEditForm.Show();
        }

        private void VehiclesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex == -1)
            {
                return;
            }

            DataGridViewRow selectedRow = vehiclesDataGridView.Rows[rowIndex];

            if (CurrentUser.IsManager)
            {
                Vehicle selectedVehicle = selectedRow.DataBoundItem as Vehicle;
                VehicleEditForm vehicleEditForm = Program.GetService<VehicleEditForm>();
                vehicleEditForm.LogisticsFormInstance = this;
                vehicleEditForm.CurrentUser = CurrentUser;
                vehicleEditForm.SelectedVehicle = selectedVehicle;
                vehicleEditForm.Show();
            }
        }

        private void ReportsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex == -1)
            { return; }

            DialogResult dialogResult = MessageBox.Show("Do you want to cancel order ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = reportsDataGridView.Rows[rowIndex];

                Report selectedReport = selectedRow.DataBoundItem as Report;

                _reportService.Delete(selectedReport);

                UpdateReportsDataGridViewDataSource();
            }
        }
        // Cell Content Double Click End

        // Create Button Click Start
        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            ProductCreateForm productCreateForm = Program.GetService<ProductCreateForm>();
            productCreateForm.LogisticsFormInstance = this;
            productCreateForm.CurrentUser = CurrentUser;
            productCreateForm.Show();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            OrderCreateForm orderCreateForm = Program.GetService<OrderCreateForm>();
            orderCreateForm.LogisticsFormInstance = this;
            orderCreateForm.CurrentUser = CurrentUser;
            orderCreateForm.Show();
        }

        private void CreateVehicleButton_Click(object sender, EventArgs e)
        {
            VehicleCreateForm vehicleCreateForm = Program.GetService<VehicleCreateForm>();
            vehicleCreateForm.LogisticsFormInstance = this;
            vehicleCreateForm.CurrentUser = CurrentUser;
            vehicleCreateForm.Show();
        }

        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            ReportCreateForm reportCreateForm = Program.GetService<ReportCreateForm>();
            reportCreateForm.LogisticsFormInstance = this;
            reportCreateForm.CurrentUser = CurrentUser;
            reportCreateForm.Show();
        }
        // Button Click End
        public void UpdateUsersDataGridViewDataSource(string search = "")
        {
            List<User> users = _userService.Search(search).OrderBy(u => u.Email).ToList();

            if (CurrentUser.IsManager || CurrentUser.IsSuperUser)
            {
                usersDataGridView.DataSource = users.ToList();
            } else {
                usersDataGridView.DataSource = users.Where(u => u.Status == true).ToList();
            }
        }

        public void UpdateProductsDataGridViewDataSource(string search = "")
        {
            List<Product> products = _productService.Search(search);

            productsDataGridView.DataSource = products.OrderBy(p => p.Name).ToList();
        }

        public void UpdateOrdersDataGridViewDataSource(string seach = "")
        {
            List<OrderDetailDto> orders = _orderService.Search(seach);

            ordersDataGridView.DataSource = orders.OrderByDescending(o => o.OrderId).ToList();
        }

        public void UpdateVehiclesDataGridViewDataSource(string search = "")
        {
            List<Vehicle> vehicles = _vehicleService.Search(search);

            vehiclesDataGridView.DataSource = vehicles.OrderBy(v => v.Id).ToList();
        }

        public void UpdateReportsDataGridViewDataSource(string search = "")
        {
            List<Report> reports = _reportService.Search(search);

            reportsDataGridView.DataSource = reports.OrderByDescending(r => r.Id).ToList();
        }

        private void HandleVisibleUsersDataGridViewColumns()
        {
            usersDataGridView.Columns["Id"].Visible = CurrentUser.IsManager;
            usersDataGridView.Columns["Username"].Visible = CurrentUser.IsManager;
            usersDataGridView.Columns["Email"].Visible = true;
            usersDataGridView.Columns["Password"].Visible = false;
            usersDataGridView.Columns["FirstName"].Visible = true;
            usersDataGridView.Columns["LastName"].Visible = true;
            usersDataGridView.Columns["City"].Visible = CurrentUser.IsManager;
            usersDataGridView.Columns["Address"].Visible = false;
            usersDataGridView.Columns["Birthdate"].Visible = false;
            usersDataGridView.Columns["Phone"].Visible = CurrentUser.IsManager;
            usersDataGridView.Columns["Salary"].Visible = CurrentUser.IsManager;
            usersDataGridView.Columns["Status"].Visible = CurrentUser.IsManager;
            usersDataGridView.Columns["IsManager"].Visible = true;
            usersDataGridView.Columns["IsSuperUser"].Visible = (CurrentUser.IsSuperUser) ? true : false;
        }

        private void HandleVisibleProductsDataGridViewColumns()
        {
            productsDataGridView.Columns["Id"].Visible = true;
            productsDataGridView.Columns["Name"].Visible = true;
            productsDataGridView.Columns["Price"].Visible = true;
            productsDataGridView.Columns["Weight"].Visible = true;
            productsDataGridView.Columns["StockQuantity"].Visible = true;
        }

        private void HandleVisibleOrdersDataGridViewColumns()
        {
            ordersDataGridView.Columns["OrderId"].Visible = true;
            ordersDataGridView.Columns["VehicleId"].Visible = false;
            ordersDataGridView.Columns["VehiclePlate"].Visible = true;
            ordersDataGridView.Columns["PendingDate"].Visible = true;
            ordersDataGridView.Columns["ShippedDate"].Visible = true;
            ordersDataGridView.Columns["DeliveredDate"].Visible = true;
            ordersDataGridView.Columns["CanceledDate"].Visible = true;
            ordersDataGridView.Columns["TotalWeight"].Visible = true;
            ordersDataGridView.Columns["DestinationAddress"].Visible = false;
            ordersDataGridView.Columns["OrderStatus"].Visible = true;
        }

        private void HandleVisibleReportsDataGridViewColumns()
        {
            reportsDataGridView.Columns["Id"].Visible = true;
            reportsDataGridView.Columns["CreatedDate"].Visible = true;
            reportsDataGridView.Columns["StartDate"].Visible = true;
            reportsDataGridView.Columns["EndDate"].Visible = true;
            reportsDataGridView.Columns["TotalProductPrice"].Visible = true;
            reportsDataGridView.Columns["PersonalTotalSalary"].Visible = true;
            reportsDataGridView.Columns["ExpenseOfVehicles"].Visible = true;
            reportsDataGridView.Columns["Result"].Visible = true;
        }
        
        private DataTable GetDataTable(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, typeof(string));
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataTable.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(c => c.Value).ToArray());
            }

            return dataTable;
        }

        private void SaveToExcel(DataTable dataTable, string filePath, string worksheetName)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(worksheetName);
                worksheet.Cell(1, 1).InsertTable(dataTable);
                workbook.SaveAs(filePath);
            }
        }

        private void ShowSaveFileDialog(DataTable dataTable, string filename)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = $"{filename}.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string worksheetName = "1";

                    SaveToExcel(dataTable, filePath, worksheetName);
                }
            }
        }

        private void ExportReportsExcel_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog(GetDataTable(reportsDataGridView), "Reports");
        }

        private void ExportVehiclesExcel_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog(GetDataTable(vehiclesDataGridView), "Vehicles");
        }

        private void ExportOrdersExcel_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog(GetDataTable(ordersDataGridView), "Orders");
        }

        private void ExportProductsExcel_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog(GetDataTable(productsDataGridView), "Products");
        }

        private void ExportUsersExcel_Click(object sender, EventArgs e)
        {
            ShowSaveFileDialog(GetDataTable(usersDataGridView), "Users");
        }
    }
}
