using DataAccess.Entities;
using FinalProjectFormsApp.Forms.UserForms;
using Services.Services.Abstracts;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProjectFormsApp
{
    public partial class LoginForm : Form
    {
        private IUserService _userService;
        public User CurrentUser { get; set; } = null;
        private int currentNumberOfLoginAttempt = 0;
        private int maxNumberOfLoginAttempt = 3;

        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = Program.GetService<RegisterForm>();
            registerForm.LoginFormInstance = this;
            registerForm.Show();
            Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string enteredUsername = username.Text;
            string enteredPassword = password.Text;

            var result = _userService.Login(enteredUsername, enteredPassword);

            if (result.Success)
            {
                CurrentUser = result.Data;
                LogisticsForm logisticsForm = Program.GetService<LogisticsForm>();
                logisticsForm.LoginFormInstance = this;
                logisticsForm.CurrentUser = this.CurrentUser;
                logisticsForm.Show();
                this.Hide();
            } else { 
                HandleLoginFailure(result.Message);
            }
        }

        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z0-9_]*$") && char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void HandleLoginFailure(string message)
        {
            if (currentNumberOfLoginAttempt <= maxNumberOfLoginAttempt)
            {
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                this.Close();
            }
            currentNumberOfLoginAttempt++;
        }
    }
}
