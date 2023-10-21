namespace FinalProjectFormsApp.Forms.OrderItemForms
{
    partial class OrderItemCreateForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfProduct = new System.Windows.Forms.NumericUpDown();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.currentStock = new System.Windows.Forms.TextBox();
            this.calculatedWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select a Product:";
            // 
            // productsComboBox
            // 
            this.productsComboBox.FormattingEnabled = true;
            this.productsComboBox.Location = new System.Drawing.Point(138, 18);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(121, 21);
            this.productsComboBox.TabIndex = 12;
            this.productsComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductsComboBox_SelectedIndexChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Number of Product :";
            // 
            // numberOfProduct
            // 
            this.numberOfProduct.Location = new System.Drawing.Point(138, 104);
            this.numberOfProduct.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberOfProduct.Name = "numberOfProduct";
            this.numberOfProduct.Size = new System.Drawing.Size(120, 20);
            this.numberOfProduct.TabIndex = 55;
            this.numberOfProduct.ValueChanged += new System.EventHandler(this.NumberOfProduct_ValueChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(110, 130);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 57;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Current Stock:";
            // 
            // currentStock
            // 
            this.currentStock.Location = new System.Drawing.Point(138, 48);
            this.currentStock.MaxLength = 3276700;
            this.currentStock.Name = "currentStock";
            this.currentStock.ReadOnly = true;
            this.currentStock.Size = new System.Drawing.Size(121, 20);
            this.currentStock.TabIndex = 59;
            this.currentStock.Text = "0";
            this.currentStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculatedWeight
            // 
            this.calculatedWeight.Location = new System.Drawing.Point(137, 78);
            this.calculatedWeight.MaxLength = 3276700;
            this.calculatedWeight.Name = "calculatedWeight";
            this.calculatedWeight.ReadOnly = true;
            this.calculatedWeight.Size = new System.Drawing.Size(121, 20);
            this.calculatedWeight.TabIndex = 61;
            this.calculatedWeight.Text = "0";
            this.calculatedWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Weight :";
            // 
            // OrderItemCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 161);
            this.Controls.Add(this.calculatedWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsComboBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(329, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(329, 200);
            this.Name = "OrderItemCreateForm";
            this.Text = "OrderItemForm";
            this.Load += new System.EventHandler(this.OrderItemCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfProduct;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentStock;
        private System.Windows.Forms.TextBox calculatedWeight;
        private System.Windows.Forms.Label label4;
    }
}