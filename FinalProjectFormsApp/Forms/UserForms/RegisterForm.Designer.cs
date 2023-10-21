namespace FinalProjectFormsApp.Forms.UserForms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(87, 73);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(233, 20);
            this.firstName.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(408, 72);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(233, 20);
            this.lastName.TabIndex = 1;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(104, 340);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(200, 20);
            this.birthdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // username
            // 
            this.username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.username.Location = new System.Drawing.Point(87, 130);
            this.username.MaxLength = 16;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(233, 20);
            this.username.TabIndex = 5;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username_Keypress);
            this.username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E-mail";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(87, 185);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(233, 20);
            this.email.TabIndex = 7;
            this.email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(87, 236);
            this.password.MaxLength = 16;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(233, 20);
            this.password.TabIndex = 9;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            this.password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Password_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(87, 287);
            this.confirmPassword.MaxLength = 16;
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(233, 20);
            this.confirmPassword.TabIndex = 11;
            this.confirmPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ConfirmPassword_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Birthdate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(408, 235);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(233, 98);
            this.address.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "City";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(408, 184);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(233, 20);
            this.city.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Phone";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(408, 129);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(233, 20);
            this.phone.TabIndex = 18;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(122, 396);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(150, 46);
            this.submit.TabIndex = 20;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(458, 411);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(132, 23);
            this.login.TabIndex = 21;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.OnClickLogin);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Already have an account ?";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.login);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(756, 512);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(756, 512);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}