using DataAccess.Entities;
using DataAccess.Repositories.Abstracts;
using FluentValidation.Results;
using Services.Services.Abstracts;
using Services.Validations;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProjectFormsApp.Forms.UserForms
{
    public partial class RegisterForm : Form
    {
        private IUserService _userService;
        public LoginForm LoginFormInstance { get; set; }
        public RegisterForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void OnClickLogin(object sender, EventArgs e)
        {
            this.LoginFormInstance.Show();
            Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = username.Text;
            user.Email = email.Text;
            user.Password = password.Text;
            user.FirstName = firstName.Text;
            user.LastName = lastName.Text;
            user.City = city.Text;
            user.Address = address.Text;
            user.Birthdate = birthdate.Value;
            user.Phone = phone.Text;

            UserValidator validator = Program.GetService<UserValidator>();
            ValidationResult result = validator.Validate(user);
            if (result.IsValid)
            {
                // Add user object in database
                _userService.Register(user);

                MessageBox.Show("Account Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoginFormInstance.Show();
                Close();
            } else
            {
                string errorMessage = "";
                foreach (var failure in result.Errors)
                {
                    errorMessage += $"{failure.ErrorMessage}\n";
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Username Already Exists
        private void Username_Leave(object sender, EventArgs e)
        {
            if (_userService.Search().Any(u => u.Username == username.Text))
            {
                errorProvider.SetError(username, "Username Already Exists.");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        // Email Already Exists
        private void Email_Leave(object sender, EventArgs e)
        {
            if (_userService.Search().Any(u => u.Email == email.Text))
            {
                errorProvider.SetError(email, "Email Already Exists.");
            }
            else
            {
                errorProvider.Clear();
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

        private void Username_Keypress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z0-9_]*$") && char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
