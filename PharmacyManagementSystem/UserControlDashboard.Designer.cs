namespace PharmacyManagementSystem
{
    partial class UserControlDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrderHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewLowStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewExpiryItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelWelcomeTab = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelDisplayExpiryCount = new System.Windows.Forms.Label();
            this.labelDisplayLowStockCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLowStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpiryItems)).BeginInit();
            this.panelWelcomeTab.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(16, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 99;
            this.label1.Text = "Dashboard";
            // 
            // dataGridViewOrderHistory
            // 
            this.dataGridViewOrderHistory.AllowUserToAddRows = false;
            this.dataGridViewOrderHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrderHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewOrderHistory.ColumnHeadersHeight = 20;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderHistory.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewOrderHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewOrderHistory.Location = new System.Drawing.Point(22, 402);
            this.dataGridViewOrderHistory.Name = "dataGridViewOrderHistory";
            this.dataGridViewOrderHistory.ReadOnly = true;
            this.dataGridViewOrderHistory.RowHeadersVisible = false;
            this.dataGridViewOrderHistory.RowHeadersWidth = 51;
            this.dataGridViewOrderHistory.Size = new System.Drawing.Size(634, 171);
            this.dataGridViewOrderHistory.TabIndex = 107;
            this.dataGridViewOrderHistory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewOrderHistory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewOrderHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOrderHistory.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridViewOrderHistory.ThemeStyle.ReadOnly = true;
            this.dataGridViewOrderHistory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(20, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 108;
            this.label2.Text = "Purchase History";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 111;
            this.label4.Text = "Low On Stock";
            // 
            // dataGridViewLowStock
            // 
            this.dataGridViewLowStock.AllowUserToAddRows = false;
            this.dataGridViewLowStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dataGridViewLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewLowStock.ColumnHeadersHeight = 40;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLowStock.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewLowStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewLowStock.Location = new System.Drawing.Point(18, 201);
            this.dataGridViewLowStock.Name = "dataGridViewLowStock";
            this.dataGridViewLowStock.ReadOnly = true;
            this.dataGridViewLowStock.RowHeadersVisible = false;
            this.dataGridViewLowStock.RowHeadersWidth = 51;
            this.dataGridViewLowStock.Size = new System.Drawing.Size(300, 155);
            this.dataGridViewLowStock.TabIndex = 110;
            this.dataGridViewLowStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewLowStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLowStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLowStock.ThemeStyle.HeaderStyle.Height = 40;
            this.dataGridViewLowStock.ThemeStyle.ReadOnly = true;
            this.dataGridViewLowStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 113;
            this.label3.Text = "Expiry Alert";
            // 
            // dataGridViewExpiryItems
            // 
            this.dataGridViewExpiryItems.AllowUserToAddRows = false;
            this.dataGridViewExpiryItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dataGridViewExpiryItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpiryItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewExpiryItems.ColumnHeadersHeight = 20;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExpiryItems.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewExpiryItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewExpiryItems.Location = new System.Drawing.Point(354, 201);
            this.dataGridViewExpiryItems.Name = "dataGridViewExpiryItems";
            this.dataGridViewExpiryItems.ReadOnly = true;
            this.dataGridViewExpiryItems.RowHeadersVisible = false;
            this.dataGridViewExpiryItems.RowHeadersWidth = 51;
            this.dataGridViewExpiryItems.Size = new System.Drawing.Size(300, 155);
            this.dataGridViewExpiryItems.TabIndex = 112;
            this.dataGridViewExpiryItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewExpiryItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewExpiryItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewExpiryItems.ThemeStyle.HeaderStyle.Height = 20;
            this.dataGridViewExpiryItems.ThemeStyle.ReadOnly = true;
            this.dataGridViewExpiryItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelWelcomeTab
            // 
            this.panelWelcomeTab.BackColor = System.Drawing.Color.Transparent;
            this.panelWelcomeTab.BorderRadius = 20;
            this.panelWelcomeTab.Controls.Add(this.labelDisplayLowStockCount);
            this.panelWelcomeTab.Controls.Add(this.label4);
            this.panelWelcomeTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.panelWelcomeTab.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.panelWelcomeTab.Location = new System.Drawing.Point(13, 43);
            this.panelWelcomeTab.Margin = new System.Windows.Forms.Padding(2);
            this.panelWelcomeTab.Name = "panelWelcomeTab";
            this.panelWelcomeTab.Size = new System.Drawing.Size(310, 142);
            this.panelWelcomeTab.TabIndex = 114;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.labelDisplayExpiryCount);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(350, 43);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(310, 142);
            this.guna2GradientPanel1.TabIndex = 115;
            // 
            // labelDisplayExpiryCount
            // 
            this.labelDisplayExpiryCount.AutoSize = true;
            this.labelDisplayExpiryCount.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayExpiryCount.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDisplayExpiryCount.Location = new System.Drawing.Point(116, 52);
            this.labelDisplayExpiryCount.Name = "labelDisplayExpiryCount";
            this.labelDisplayExpiryCount.Size = new System.Drawing.Size(47, 65);
            this.labelDisplayExpiryCount.TabIndex = 114;
            this.labelDisplayExpiryCount.Text = "t";
            // 
            // labelDisplayLowStockCount
            // 
            this.labelDisplayLowStockCount.AutoSize = true;
            this.labelDisplayLowStockCount.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisplayLowStockCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(76)))), ((int)(((byte)(120)))));
            this.labelDisplayLowStockCount.Location = new System.Drawing.Point(113, 52);
            this.labelDisplayLowStockCount.Name = "labelDisplayLowStockCount";
            this.labelDisplayLowStockCount.Size = new System.Drawing.Size(47, 65);
            this.labelDisplayLowStockCount.TabIndex = 115;
            this.labelDisplayLowStockCount.Text = "t";
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewExpiryItems);
            this.Controls.Add(this.dataGridViewLowStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOrderHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelWelcomeTab);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(680, 610);
            this.Load += new System.EventHandler(this.UserControlDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLowStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpiryItems)).EndInit();
            this.panelWelcomeTab.ResumeLayout(false);
            this.panelWelcomeTab.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewOrderHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewLowStock;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewExpiryItems;
        private Guna.UI2.WinForms.Guna2GradientPanel panelWelcomeTab;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label labelDisplayExpiryCount;
        private System.Windows.Forms.Label labelDisplayLowStockCount;
    }
}
