namespace FinalProjectFormsApp.Forms.OrderForms
{
    partial class OrderEditForm
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
            this.destinationAddressLabel = new System.Windows.Forms.Label();
            this.destinationAddress = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pendingDate = new System.Windows.Forms.DateTimePicker();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicle = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ratio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shippedDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.deliveredDate = new System.Windows.Forms.DateTimePicker();
            this.canceledDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // destinationAddressLabel
            // 
            this.destinationAddressLabel.AutoSize = true;
            this.destinationAddressLabel.Location = new System.Drawing.Point(37, 30);
            this.destinationAddressLabel.Name = "destinationAddressLabel";
            this.destinationAddressLabel.Size = new System.Drawing.Size(101, 13);
            this.destinationAddressLabel.TabIndex = 5;
            this.destinationAddressLabel.Text = "Destination Address";
            // 
            // destinationAddress
            // 
            this.destinationAddress.Location = new System.Drawing.Point(31, 46);
            this.destinationAddress.Multiline = true;
            this.destinationAddress.Name = "destinationAddress";
            this.destinationAddress.Size = new System.Drawing.Size(233, 148);
            this.destinationAddress.TabIndex = 4;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Location = new System.Drawing.Point(334, 51);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(121, 21);
            this.status.TabIndex = 6;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(561, 272);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // items
            // 
            this.items.AutoSize = true;
            this.items.Location = new System.Drawing.Point(558, 30);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(32, 13);
            this.items.TabIndex = 9;
            this.items.Text = "Items";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(642, 272);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 10;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Status";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(308, 80);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(72, 13);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "Pending Date";
            // 
            // pendingDate
            // 
            this.pendingDate.Location = new System.Drawing.Point(311, 96);
            this.pendingDate.Name = "pendingDate";
            this.pendingDate.Size = new System.Drawing.Size(200, 20);
            this.pendingDate.TabIndex = 14;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Location = new System.Drawing.Point(55, 272);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(150, 46);
            this.edit.TabIndex = 21;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete.Location = new System.Drawing.Point(72, 337);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 36);
            this.delete.TabIndex = 22;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(561, 96);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(156, 160);
            this.listBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Vehicle";
            // 
            // vehicle
            // 
            this.vehicle.FormattingEnabled = true;
            this.vehicle.Location = new System.Drawing.Point(71, 225);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(121, 21);
            this.vehicle.TabIndex = 24;
            this.vehicle.SelectedIndexChanged += new System.EventHandler(this.Vehicle_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(561, 67);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(156, 23);
            this.progressBar.TabIndex = 39;
            // 
            // ratio
            // 
            this.ratio.AutoSize = true;
            this.ratio.Location = new System.Drawing.Point(616, 51);
            this.ratio.Name = "ratio";
            this.ratio.Size = new System.Drawing.Size(0, 13);
            this.ratio.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Shipped Date";
            // 
            // shippedDate
            // 
            this.shippedDate.Location = new System.Drawing.Point(311, 148);
            this.shippedDate.Name = "shippedDate";
            this.shippedDate.Size = new System.Drawing.Size(200, 20);
            this.shippedDate.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Delivered Date";
            // 
            // deliveredDate
            // 
            this.deliveredDate.Location = new System.Drawing.Point(311, 197);
            this.deliveredDate.Name = "deliveredDate";
            this.deliveredDate.Size = new System.Drawing.Size(200, 20);
            this.deliveredDate.TabIndex = 43;
            // 
            // canceledDate
            // 
            this.canceledDate.Location = new System.Drawing.Point(311, 249);
            this.canceledDate.Name = "canceledDate";
            this.canceledDate.Size = new System.Drawing.Size(200, 20);
            this.canceledDate.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Canceled Date";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Location = new System.Drawing.Point(594, 379);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(13, 13);
            this.currentDateLabel.TabIndex = 47;
            this.currentDateLabel.Text = "_";
            // 
            // OrderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 401);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.canceledDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deliveredDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shippedDate);
            this.Controls.Add(this.ratio);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicle);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.pendingDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.items);
            this.Controls.Add(this.add);
            this.Controls.Add(this.status);
            this.Controls.Add(this.destinationAddressLabel);
            this.Controls.Add(this.destinationAddress);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(768, 440);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(768, 440);
            this.Name = "OrderEditForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label destinationAddressLabel;
        private System.Windows.Forms.TextBox destinationAddress;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label items;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker pendingDate;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vehicle;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ratio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker shippedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker deliveredDate;
        private System.Windows.Forms.DateTimePicker canceledDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label currentDateLabel;
    }
}