using DataAccess.Entities;
using Services.Services.Abstracts;
using System;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.VehicleForms
{
    public partial class VehicleEditForm : Form
    {
        private IVehicleService _vehicleService;

        public Vehicle SelectedVehicle { get; set; }
        public LogisticsForm LogisticsFormInstance { get; set; }
        public User CurrentUser { get; set; }

        public VehicleEditForm(IVehicleService vehicleService)
        {
            InitializeComponent();
            _vehicleService = vehicleService;
        }

        private void VehicleEditForm_Load(object sender, EventArgs e)
        {
            this.Text = SelectedVehicle.Plate;

            plate.Text = SelectedVehicle.Plate;
            capacity.Value = SelectedVehicle.Capacity;
            isAvailable.Checked = SelectedVehicle.IsAvailable;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            SelectedVehicle.Plate = plate.Text;
            SelectedVehicle.Capacity = capacity.Value;
            SelectedVehicle.MonthlyExpense = monthlyExpense.Value;
            SelectedVehicle.IsAvailable = isAvailable.Checked;

            var result = _vehicleService.Edit(SelectedVehicle);
            if (result.Success)
            {
                LogisticsFormInstance.UpdateVehiclesDataGridViewDataSource();
                this.Close();
                return;
            }
            MessageBox.Show(result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult messageBoxResult = MessageBox.Show("Do you want to delete vehicle ?.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (messageBoxResult == DialogResult.Yes)
            {
                var result = _vehicleService.Delete(SelectedVehicle);
                if (result.Success)
                {
                    LogisticsFormInstance.UpdateVehiclesDataGridViewDataSource();
                    this.Close();
                } else
                {
                    MessageBox.Show(result.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
