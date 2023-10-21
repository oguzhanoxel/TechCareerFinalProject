using DataAccess.Entities;
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

namespace FinalProjectFormsApp.Forms.ReportForms
{
    public partial class ReportCreateForm : Form
    {
        private IReportService _reportService;
        private IUserService _userService;
        private IVehicleService _vehicleService;
        private IProductService _productService;
        private IOrderService _orderService;
        private IOrderItemService _orderItemService;

        public LogisticsForm LogisticsFormInstance { get; set; }
        public User CurrentUser { get; set; }
        
        public ReportCreateForm(IReportService reportService, IUserService userService, IVehicleService vehicleService, IProductService productService, IOrderService orderService, IOrderItemService orderItemService)
        {
            InitializeComponent();
            _reportService = reportService;
            _userService = userService;
            _vehicleService = vehicleService;
            _productService = productService;
            _orderService = orderService;
            _orderItemService = orderItemService;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            DateTime _startDate = startDate.Value;
            DateTime _endDate = endDate.Value;

            TimeSpan difference = _endDate.Date - _startDate.Date;

            int differenceInDays = difference.Days;

            if ( differenceInDays < 7 ) {
                MessageBox.Show("Date range is less than 7 days.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Report report = new Report();
            report.CreatedDate = DateTime.Now;
            report.StartDate = _startDate;
            report.EndDate = _endDate;

            decimal personalTotalSalary = CalcPersonalsTotalSalary(differenceInDays);
            decimal expenseOfVehicles = CalcVehiclesTotalExpense(differenceInDays);
            decimal totalProductPrice = CalcDeliveredOrderProducts(_startDate, _endDate);

            report.PersonalTotalSalary = personalTotalSalary;
            report.ExpenseOfVehicles = expenseOfVehicles;
            report.TotalProductPrice = totalProductPrice;

            report.Result = totalProductPrice - (personalTotalSalary + expenseOfVehicles);

            _reportService.Create(report);

            LogisticsFormInstance.UpdateReportsDataGridViewDataSource();
            this.Close();
        }

        private decimal CalcDeliveredOrderProducts(DateTime startDate, DateTime endDate)
        {
            List<Order> orders = _orderService.GetAll(order => order.OrderStatus == OrderStatus.Delivered && startDate <= order.DeliveredDate && order.DeliveredDate <= endDate);

            decimal result = 0;
            
            foreach ( Order order in orders )
            {
                List<OrderItem> items = _orderItemService.GetListByOrderId(order.Id);
                foreach ( OrderItem item in items )
                {
                    Product product = _productService.GetById(item.ProductId);

                    result += product.Price * item.ProductQuantity;
                }
            }

            return result;
        }

        private decimal CalcVehiclesTotalExpense(decimal differenceInDays)
        {
            List<Vehicle> vehicles = _vehicleService.Search();

            decimal result = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                decimal monthlyExpense = vehicle.MonthlyExpense;
                result += (monthlyExpense / 30) * differenceInDays;
            }
            
            return result;
        }

        private decimal CalcPersonalsTotalSalary(decimal differenceInDays)
        {
            List<User> users = _userService.Search();

            decimal result = 0;

            foreach (User user in users)
            {
                decimal salary = user.Salary;
                result += (salary / 30) * differenceInDays;
            }

            return result;
        }
    }
}
