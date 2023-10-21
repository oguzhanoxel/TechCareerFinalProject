namespace FinalProjectFormsApp.Forms.VehicleForms
{
    partial class VehicleEditForm
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
            this.edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.NumericUpDown();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.plate = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.isAvailable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthlyExpense = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.edit.Location = new System.Drawing.Point(27, 165);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(86, 34);
            this.edit.TabIndex = 66;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Capacity :";
            // 
            // capacity
            // 
            this.capacity.Location = new System.Drawing.Point(27, 88);
            this.capacity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(120, 20);
            this.capacity.TabIndex = 62;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(24, 26);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(31, 13);
            this.salaryLabel.TabIndex = 61;
            this.salaryLabel.Text = "Plate";
            // 
            // plate
            // 
            this.plate.Location = new System.Drawing.Point(27, 42);
            this.plate.MaxLength = 1000000;
            this.plate.Name = "plate";
            this.plate.Size = new System.Drawing.Size(233, 20);
            this.plate.TabIndex = 60;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.GrayText;
            this.delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delete.Location = new System.Drawing.Point(174, 165);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 34);
            this.delete.TabIndex = 67;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // isAvailable
            // 
            this.isAvailable.Location = new System.Drawing.Point(174, 88);
            this.isAvailable.Name = "isAvailable";
            this.isAvailable.Size = new System.Drawing.Size(80, 17);
            this.isAvailable.TabIndex = 68;
            this.isAvailable.Text = "Is Available";
            this.isAvailable.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Monthly Expense :";
            // 
            // monthlyExpense
            // 
            this.monthlyExpense.DecimalPlaces = 2;
            this.monthlyExpense.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.monthlyExpense.Location = new System.Drawing.Point(27, 139);
            this.monthlyExpense.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.monthlyExpense.Name = "monthlyExpense";
            this.monthlyExpense.Size = new System.Drawing.Size(120, 20);
            this.monthlyExpense.TabIndex = 69;
            // 
            // VehicleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthlyExpense);
            this.Controls.Add(this.isAvailable);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.plate);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "VehicleEditForm";
            this.Text = "VehicleEditFormForm";
            this.Load += new System.EventHandler(this.VehicleEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown capacity;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox plate;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.CheckBox isAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown monthlyExpense;
    }
}