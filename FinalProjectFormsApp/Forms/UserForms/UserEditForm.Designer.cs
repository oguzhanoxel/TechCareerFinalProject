namespace FinalProjectFormsApp.Forms.UserForms
{
    partial class UserEditForm
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
            this.edit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.CheckBox();
            this.isManager = new System.Windows.Forms.CheckBox();
            this.isSuperuser = new System.Windows.Forms.CheckBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.resetPassword = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Location = new System.Drawing.Point(112, 312);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(150, 46);
            this.edit.TabIndex = 43;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Phone";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(414, 116);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(233, 20);
            this.phone.TabIndex = 41;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(422, 206);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 40;
            this.addressLabel.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(414, 222);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(233, 98);
            this.address.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "City";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(414, 171);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(233, 20);
            this.city.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "E-mail";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(93, 116);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(233, 20);
            this.email.TabIndex = 30;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(99, 155);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 29;
            this.usernameLabel.Text = "Username";
            // 
            // username
            // 
            this.username.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.username.Location = new System.Drawing.Point(93, 171);
            this.username.MaxLength = 16;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(233, 20);
            this.username.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(414, 59);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(233, 20);
            this.lastName.TabIndex = 24;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(93, 60);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(233, 20);
            this.firstName.TabIndex = 23;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(90, 269);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(67, 17);
            this.status.TabIndex = 44;
            this.status.Text = "Is Active";
            this.status.UseVisualStyleBackColor = true;
            // 
            // isManager
            // 
            this.isManager.AutoSize = true;
            this.isManager.Location = new System.Drawing.Point(171, 269);
            this.isManager.Name = "isManager";
            this.isManager.Size = new System.Drawing.Size(79, 17);
            this.isManager.TabIndex = 45;
            this.isManager.Text = "Is Manager";
            this.isManager.UseVisualStyleBackColor = true;
            // 
            // isSuperuser
            // 
            this.isSuperuser.AutoSize = true;
            this.isSuperuser.Location = new System.Drawing.Point(256, 269);
            this.isSuperuser.Name = "isSuperuser";
            this.isSuperuser.Size = new System.Drawing.Size(85, 17);
            this.isSuperuser.TabIndex = 46;
            this.isSuperuser.Text = "Is Superuser";
            this.isSuperuser.UseVisualStyleBackColor = true;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(422, 332);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 48;
            this.salaryLabel.Text = "Salary";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(414, 348);
            this.salary.MaxLength = 1000000;
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(233, 20);
            this.salary.TabIndex = 47;
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(112, 222);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(200, 20);
            this.birthdate.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Birthdate";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // resetPassword
            // 
            this.resetPassword.BackColor = System.Drawing.SystemColors.GrayText;
            this.resetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetPassword.Location = new System.Drawing.Point(76, 375);
            this.resetPassword.Name = "resetPassword";
            this.resetPassword.Size = new System.Drawing.Size(236, 34);
            this.resetPassword.TabIndex = 49;
            this.resetPassword.Text = "Reset Password";
            this.resetPassword.UseVisualStyleBackColor = false;
            this.resetPassword.Click += new System.EventHandler(this.Reset_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.GrayText;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(244, 427);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(236, 34);
            this.delete.TabIndex = 50;
            this.delete.Text = "Delete User";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 473);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.resetPassword);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.isSuperuser);
            this.Controls.Add(this.isManager);
            this.Controls.Add(this.status);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.usernameLabel);
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
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.CheckBox isManager;
        private System.Windows.Forms.CheckBox isSuperuser;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button resetPassword;
        private System.Windows.Forms.Button delete;
    }
}