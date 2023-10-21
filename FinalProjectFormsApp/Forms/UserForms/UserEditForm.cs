using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;
using Services;
using Services.Services.Abstracts;
using System;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.UserForms
{
    public partial class UserEditForm : Form
    {
        private IUserService _userService;
        public LogisticsForm LogisticsFormInstance { get; set; }
        public User CurrentUser { get; set; }
        public User User { get; set; }

        public UserEditForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            MappingUserToUserForm();
            HandleReadOnlyUsersTextBox();
            HandleVisibleUsersTextBox();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogisticsFormInstance.UpdateUsersDataGridViewDataSource();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            User.Username = username.Text;
            User.Email = email.Text;
            User.FirstName = firstName.Text;
            User.LastName = lastName.Text;
            User.City = city.Text;
            User.Address = address.Text;
            User.Birthdate = birthdate.Value;
            User.Phone = phone.Text;
            User.Salary = Convert.ToDecimal(salary.Text);
            User.Status = status.Checked;
            User.IsManager = isManager.Checked;
            User.IsSuperUser = isSuperuser.Checked;

            var result = _userService.Edit(User);
            MessageBox.Show(result.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LogisticsFormInstance.UpdateUsersDataGridViewDataSource();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            PasswordResetForm passwordResetForm = Program.GetService<PasswordResetForm>();
            passwordResetForm.CurrentUser = CurrentUser;
            passwordResetForm.Show();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete user ?.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _userService.Delete(User);
                MessageBox.Show("User deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void HandleVisibleUsersTextBox()
        {
            firstName.Visible = true;
            lastName.Visible = true;
            username.Visible = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            usernameLabel.Visible = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            email.Visible = true;
            phone.Visible = true;
            city.Visible = true;
            address.Visible = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            addressLabel.Visible = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            salary.Visible = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            salaryLabel.Visible = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            birthdate.Visible = true;
            status.Visible = (CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            isManager.Visible = true;
            isSuperuser.Visible = (CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            edit.Visible = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            resetPassword.Visible = (CurrentUser.Id == User.Id) ? true : false;
            delete.Visible = (CurrentUser.IsSuperUser) ? true : false;
        }

        private void HandleReadOnlyUsersTextBox()
        {
            firstName.ReadOnly = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser) ? false : true;
            lastName.ReadOnly = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser) ? false : true;
            username.ReadOnly = (CurrentUser.Id == User.Id) ? false : true;
            email.ReadOnly = (CurrentUser.Id == User.Id) ? false : true;
            phone.ReadOnly = (CurrentUser.Id == User.Id) ? false : true;
            city.ReadOnly = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? false : true;
            address.ReadOnly = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? false : true;
            salary.ReadOnly = (CurrentUser.IsSuperUser || CurrentUser.IsManager) ? false : true;
            birthdate.Enabled = (CurrentUser.Id == User.Id || CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            status.Enabled = (CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            isManager.Enabled = (CurrentUser.IsSuperUser || CurrentUser.IsManager) ? true : false;
            isSuperuser.Enabled = (CurrentUser.IsSuperUser) ? true : false;
        }

        private void MappingUserToUserForm()
        {
            firstName.Text = User.FirstName;
            lastName.Text = User.LastName;
            username.Text = User.Username;
            email.Text = User.Email;
            phone.Text = User.Phone;
            city.Text = User.City;
            address.Text = User.Address;
            birthdate.Value = User.Birthdate;
            salary.Text = User.Salary.ToString();
            status.Checked = User.Status;
            isManager.Checked = User.IsManager;
            isSuperuser.Checked = User.IsSuperUser;
        }
    }
}
