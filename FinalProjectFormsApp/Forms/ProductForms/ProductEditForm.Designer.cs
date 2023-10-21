namespace FinalProjectFormsApp.Forms.ProductForms
{
    partial class ProductEditForm
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
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.GrayText;
            this.delete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delete.Location = new System.Drawing.Point(219, 130);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 34);
            this.delete.TabIndex = 66;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.edit.Location = new System.Drawing.Point(219, 80);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(86, 34);
            this.edit.TabIndex = 64;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Stock :";
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(44, 157);
            this.stock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(120, 20);
            this.stock.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Price :";
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.price.Location = new System.Drawing.Point(44, 68);
            this.price.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(120, 20);
            this.price.TabIndex = 60;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(41, 9);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(75, 13);
            this.salaryLabel.TabIndex = 59;
            this.salaryLabel.Text = "Product Name";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(44, 25);
            this.productName.MaxLength = 1000000;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(233, 20);
            this.productName.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Weight :";
            // 
            // weight
            // 
            this.weight.DecimalPlaces = 2;
            this.weight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.weight.Location = new System.Drawing.Point(44, 113);
            this.weight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(120, 20);
            this.weight.TabIndex = 67;
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 198);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.productName);
            this.MaximumSize = new System.Drawing.Size(374, 237);
            this.MinimumSize = new System.Drawing.Size(374, 237);
            this.Name = "ProductEditForm";
            this.Text = "ProductEditForm";
            this.Load += new System.EventHandler(this.ProductEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown weight;
    }
}