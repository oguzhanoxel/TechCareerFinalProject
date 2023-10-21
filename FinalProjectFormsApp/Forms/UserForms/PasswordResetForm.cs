using DataAccess.Entities;
using Services.Services.Abstracts;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.UserForms
{
    public partial class PasswordResetForm : Form
    {
        private IUserService _userService;
        public User CurrentUser { get; set; }

        public PasswordResetForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            var result = _userService.PasswordReset(CurrentUser, password.Text, confirmPassword.Text);

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                errorProvider.SetError(confirmPassword, result.Message);
            }
        }

        private void Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (!Regex.IsMatch(password.Text, "^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$"))
            {
                errorProvider.SetError(password, "Minimum eight characters, at least one letter and one number");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void ConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (password.Text != confirmPassword.Text)
            {
                errorProvider.SetError(confirmPassword, "Does not match password");
            }
            else
            {
                errorProvider.Clear();
            }
        }
    }
}
