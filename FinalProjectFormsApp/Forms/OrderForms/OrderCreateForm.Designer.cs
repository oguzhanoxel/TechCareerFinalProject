namespace FinalProjectFormsApp.Forms.OrderForms
{
    partial class OrderCreateForm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.create = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.destinationAddressLabel = new System.Windows.Forms.Label();
            this.destinationAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicle = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ratio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(298, 93);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(156, 173);
            this.listBox.TabIndex = 35;
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.SystemColors.HotTrack;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.create.Location = new System.Drawing.Point(64, 246);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(150, 46);
            this.create.TabIndex = 33;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.Create_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(379, 269);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 29;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // items
            // 
            this.items.AutoSize = true;
            this.items.Location = new System.Drawing.Point(295, 32);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(32, 13);
            this.items.TabIndex = 28;
            this.items.Text = "Items";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(298, 269);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 27;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // destinationAddressLabel
            // 
            this.destinationAddressLabel.AutoSize = true;
            this.destinationAddressLabel.Location = new System.Drawing.Point(36, 32);
            this.destinationAddressLabel.Name = "destinationAddressLabel";
            this.destinationAddressLabel.Size = new System.Drawing.Size(101, 13);
            this.destinationAddressLabel.TabIndex = 25;
            this.destinationAddressLabel.Text = "Destination Address";
            // 
            // destinationAddress
            // 
            this.destinationAddress.Location = new System.Drawing.Point(30, 48);
            this.destinationAddress.Multiline = true;
            this.destinationAddress.Name = "destinationAddress";
            this.destinationAddress.Size = new System.Drawing.Size(233, 90);
            this.destinationAddress.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Vehicle";
            // 
            // vehicle
            // 
            this.vehicle.FormattingEnabled = true;
            this.vehicle.Location = new System.Drawing.Point(74, 180);
            this.vehicle.Name = "vehicle";
            this.vehicle.Size = new System.Drawing.Size(121, 21);
            this.vehicle.TabIndex = 36;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(298, 64);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(156, 23);
            this.progressBar.TabIndex = 38;
            // 
            // ratio
            // 
            this.ratio.AutoSize = true;
            this.ratio.Location = new System.Drawing.Point(357, 48);
            this.ratio.Name = "ratio";
            this.ratio.Size = new System.Drawing.Size(0, 13);
            this.ratio.TabIndex = 39;
            // 
            // OrderCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 341);
            this.Controls.Add(this.ratio);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicle);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.create);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.items);
            this.Controls.Add(this.add);
            this.Controls.Add(this.destinationAddressLabel);
            this.Controls.Add(this.destinationAddress);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(512, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(512, 380);
            this.Name = "OrderCreateForm";
            this.Text = "OrderCreateForm";
            this.Load += new System.EventHandler(this.OrderCreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Label items;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label destinationAddressLabel;
        private System.Windows.Forms.TextBox destinationAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vehicle;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ratio;
    }
}