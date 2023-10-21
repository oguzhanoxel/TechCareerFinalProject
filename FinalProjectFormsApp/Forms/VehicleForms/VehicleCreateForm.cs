using DataAccess.Entities;
using Services.Services.Abstracts;
using System;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.VehicleForms
{
    public partial class VehicleCreateForm : Form
    {
        private IVehicleService _vehicleService;

        public User CurrentUser { get; set; }
        public LogisticsForm LogisticsFormInstance { get; set; }

        public VehicleCreateForm(IVehicleService vehicleService)
        {
            InitializeComponent();
            _vehicleService = vehicleService;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Plate = plate.Text;
            vehicle.MonthlyExpense = monthlyExpense.Value;
            vehicle.Capacity = capacity.Value;
            vehicle.IsAvailable = isAvailable.Checked;
            _vehicleService.Add(vehicle);
            LogisticsFormInstance.UpdateVehiclesDataGridViewDataSource();
            this.Close();
        }
    }
}
