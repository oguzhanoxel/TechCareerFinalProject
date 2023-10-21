namespace FinalProjectFormsApp
{
    partial class LogisticsForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.usersPage = new System.Windows.Forms.TabPage();
            this.userSearch = new System.Windows.Forms.TextBox();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.productsPage = new System.Windows.Forms.TabPage();
            this.createProductButton = new System.Windows.Forms.Button();
            this.productSearch = new System.Windows.Forms.TextBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.ordersPage = new System.Windows.Forms.TabPage();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.orderSearch = new System.Windows.Forms.TextBox();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.vehiclesPage = new System.Windows.Forms.TabPage();
            this.createVehicleButton = new System.Windows.Forms.Button();
            this.vehicleSearch = new System.Windows.Forms.TextBox();
            this.vehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.reportsPage = new System.Windows.Forms.TabPage();
            this.createReportButton = new System.Windows.Forms.Button();
            this.reportSearch = new System.Windows.Forms.TextBox();
            this.reportsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.usersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.productsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.ordersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.vehiclesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).BeginInit();
            this.reportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.usersPage);
            this.tabControl.Controls.Add(this.productsPage);
            this.tabControl.Controls.Add(this.ordersPage);
            this.tabControl.Controls.Add(this.vehiclesPage);
            this.tabControl.Controls.Add(this.reportsPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(728, 449);
            this.tabControl.TabIndex = 0;
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.userSearch);
            this.usersPage.Controls.Add(this.usersDataGridView);
            this.usersPage.Location = new System.Drawing.Point(4, 22);
            this.usersPage.Name = "usersPage";
            this.usersPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersPage.Size = new System.Drawing.Size(720, 423);
            this.usersPage.TabIndex = 0;
            this.usersPage.Text = "Users";
            this.usersPage.UseVisualStyleBackColor = true;
            // 
            // userSearch
            // 
            this.userSearch.Location = new System.Drawing.Point(217, 7);
            this.userSearch.Name = "userSearch";
            this.userSearch.Size = new System.Drawing.Size(279, 20);
            this.userSearch.TabIndex = 1;
            this.userSearch.Text = "Search ...";
            this.userSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserSearch_KeyUp);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(6, 33);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowTemplate.Height = 30;
            this.usersDataGridView.Size = new System.Drawing.Size(708, 384);
            this.usersDataGridView.TabIndex = 0;
            this.usersDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellContentDoubleClick);
            // 
            // productsPage
            // 
            this.productsPage.Controls.Add(this.createProductButton);
            this.productsPage.Controls.Add(this.productSearch);
            this.productsPage.Controls.Add(this.productsDataGridView);
            this.productsPage.Location = new System.Drawing.Point(4, 22);
            this.productsPage.Name = "productsPage";
            this.productsPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsPage.Size = new System.Drawing.Size(720, 423);
            this.productsPage.TabIndex = 1;
            this.productsPage.Text = "Products";
            this.productsPage.UseVisualStyleBackColor = true;
            // 
            // createProductButton
            // 
            this.createProductButton.Location = new System.Drawing.Point(6, 6);
            this.createProductButton.Name = "createProductButton";
            this.createProductButton.Size = new System.Drawing.Size(75, 23);
            this.createProductButton.TabIndex = 4;
            this.createProductButton.Text = "Create";
            this.createProductButton.UseVisualStyleBackColor = true;
            this.createProductButton.Click += new System.EventHandler(this.CreateProductButton_Click);
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(217, 6);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(279, 20);
            this.productSearch.TabIndex = 3;
            this.productSearch.Text = "Search ...";
            this.productSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductSearch_KeyUp);
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(6, 32);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowTemplate.Height = 30;
            this.productsDataGridView.Size = new System.Drawing.Size(708, 384);
            this.productsDataGridView.TabIndex = 2;
            this.productsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentDoubleClick);
            // 
            // ordersPage
            // 
            this.ordersPage.Controls.Add(this.createOrderButton);
            this.ordersPage.Controls.Add(this.orderSearch);
            this.ordersPage.Controls.Add(this.ordersDataGridView);
            this.ordersPage.Location = new System.Drawing.Point(4, 22);
            this.ordersPage.Name = "ordersPage";
            this.ordersPage.Size = new System.Drawing.Size(720, 423);
            this.ordersPage.TabIndex = 2;
            this.ordersPage.Text = "Orders";
            this.ordersPage.UseVisualStyleBackColor = true;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(6, 6);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(75, 23);
            this.createOrderButton.TabIndex = 7;
            this.createOrderButton.Text = "Create";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // orderSearch
            // 
            this.orderSearch.Location = new System.Drawing.Point(217, 6);
            this.orderSearch.Name = "orderSearch";
            this.orderSearch.Size = new System.Drawing.Size(279, 20);
            this.orderSearch.TabIndex = 6;
            this.orderSearch.Text = "Search ...";
            this.orderSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OrderSearch_KeyUp);
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(6, 32);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowTemplate.Height = 30;
            this.ordersDataGridView.Size = new System.Drawing.Size(708, 384);
            this.ordersDataGridView.TabIndex = 5;
            this.ordersDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDataGridView_CellContentDoubleClick);
            // 
            // vehiclesPage
            // 
            this.vehiclesPage.Controls.Add(this.createVehicleButton);
            this.vehiclesPage.Controls.Add(this.vehicleSearch);
            this.vehiclesPage.Controls.Add(this.vehiclesDataGridView);
            this.vehiclesPage.Location = new System.Drawing.Point(4, 22);
            this.vehiclesPage.Name = "vehiclesPage";
            this.vehiclesPage.Size = new System.Drawing.Size(720, 423);
            this.vehiclesPage.TabIndex = 3;
            this.vehiclesPage.Text = "Vehicles";
            this.vehiclesPage.UseVisualStyleBackColor = true;
            // 
            // createVehicleButton
            // 
            this.createVehicleButton.Location = new System.Drawing.Point(6, 6);
            this.createVehicleButton.Name = "createVehicleButton";
            this.createVehicleButton.Size = new System.Drawing.Size(75, 23);
            this.createVehicleButton.TabIndex = 10;
            this.createVehicleButton.Text = "Create";
            this.createVehicleButton.UseVisualStyleBackColor = true;
            this.createVehicleButton.Click += new System.EventHandler(this.CreateVehicleButton_Click);
            // 
            // vehicleSearch
            // 
            this.vehicleSearch.Location = new System.Drawing.Point(217, 6);
            this.vehicleSearch.Name = "vehicleSearch";
            this.vehicleSearch.Size = new System.Drawing.Size(279, 20);
            this.vehicleSearch.TabIndex = 9;
            this.vehicleSearch.Text = "Search ...";
            this.vehicleSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VehicleSearch_KeyUp);
            // 
            // vehiclesDataGridView
            // 
            this.vehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesDataGridView.Location = new System.Drawing.Point(6, 32);
            this.vehiclesDataGridView.Name = "vehiclesDataGridView";
            this.vehiclesDataGridView.ReadOnly = true;
            this.vehiclesDataGridView.RowTemplate.Height = 30;
            this.vehiclesDataGridView.Size = new System.Drawing.Size(708, 384);
            this.vehiclesDataGridView.TabIndex = 8;
            this.vehiclesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VehiclesDataGridView_CellContentDoubleClick);
            // 
            // reportsPage
            // 
            this.reportsPage.Controls.Add(this.createReportButton);
            this.reportsPage.Controls.Add(this.reportSearch);
            this.reportsPage.Controls.Add(this.reportsDataGridView);
            this.reportsPage.Location = new System.Drawing.Point(4, 22);
            this.reportsPage.Name = "reportsPage";
            this.reportsPage.Size = new System.Drawing.Size(720, 423);
            this.reportsPage.TabIndex = 4;
            this.reportsPage.Text = "Reports";
            this.reportsPage.UseVisualStyleBackColor = true;
            // 
            // createReportButton
            // 
            this.createReportButton.Location = new System.Drawing.Point(6, 6);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(75, 23);
            this.createReportButton.TabIndex = 13;
            this.createReportButton.Text = "Create";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.CreateReportButton_Click);
            // 
            // reportSearch
            // 
            this.reportSearch.Location = new System.Drawing.Point(217, 6);
            this.reportSearch.Name = "reportSearch";
            this.reportSearch.Size = new System.Drawing.Size(279, 20);
            this.reportSearch.TabIndex = 12;
            this.reportSearch.Text = "Search ...";
            // 
            // reportsDataGridView
            // 
            this.reportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGridView.Location = new System.Drawing.Point(6, 32);
            this.reportsDataGridView.Name = "reportsDataGridView";
            this.reportsDataGridView.ReadOnly = true;
            this.reportsDataGridView.RowTemplate.Height = 30;
            this.reportsDataGridView.Size = new System.Drawing.Size(708, 384);
            this.reportsDataGridView.TabIndex = 11;
            this.reportsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReportsDataGridView_CellContentDoubleClick);
            // 
            // LogisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 473);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(768, 512);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(768, 512);
            this.Name = "LogisticsForm";
            this.Text = "LogisticsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogisticsForm_FormClosed);
            this.Load += new System.EventHandler(this.LogisticsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.usersPage.ResumeLayout(false);
            this.usersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.productsPage.ResumeLayout(false);
            this.productsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ordersPage.ResumeLayout(false);
            this.ordersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.vehiclesPage.ResumeLayout(false);
            this.vehiclesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).EndInit();
            this.reportsPage.ResumeLayout(false);
            this.reportsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage usersPage;
        private System.Windows.Forms.TabPage productsPage;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.TextBox userSearch;
        private System.Windows.Forms.TextBox productSearch;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Button createProductButton;
        private System.Windows.Forms.TabPage ordersPage;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.TextBox orderSearch;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.TabPage vehiclesPage;
        private System.Windows.Forms.Button createVehicleButton;
        private System.Windows.Forms.TextBox vehicleSearch;
        private System.Windows.Forms.DataGridView vehiclesDataGridView;
        private System.Windows.Forms.TabPage reportsPage;
        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.TextBox reportSearch;
        private System.Windows.Forms.DataGridView reportsDataGridView;
    }
}