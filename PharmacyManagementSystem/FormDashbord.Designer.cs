namespace PharmacyManagementSystem
{
    partial class FormDashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashbord));
            this.ElipseFormDashbord = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControlFormDashboard = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PanelNavBar = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelWindowControl = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxLogoName = new System.Windows.Forms.PictureBox();
            this.PanelNavBarLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.panelNavButtons = new System.Windows.Forms.Panel();
            this.buttonDashboard = new Guna.UI2.WinForms.Guna2GradientButton();
            this.buttonMedicine = new Guna.UI2.WinForms.Guna2GradientButton();
            this.buttonDispence = new Guna.UI2.WinForms.Guna2GradientButton();
            this.buttonSupplier = new Guna.UI2.WinForms.Guna2GradientButton();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonEmployee = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PanelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelWindowControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoName)).BeginInit();
            this.PanelNavBarLogo.SuspendLayout();
            this.panelNavButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipseFormDashbord
            // 
            this.ElipseFormDashbord.BorderRadius = 30;
            this.ElipseFormDashbord.TargetControl = this;
            // 
            // DragControlFormDashboard
            // 
            this.DragControlFormDashboard.DockIndicatorTransparencyValue = 0.6D;
            this.DragControlFormDashboard.TargetControl = this.panelWindowControl;
            this.DragControlFormDashboard.UseTransparentDrag = true;
            // 
            // PanelNavBar
            // 
            this.PanelNavBar.Controls.Add(this.panelNavButtons);
            this.PanelNavBar.Controls.Add(this.PanelNavBarLogo);
            this.PanelNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelNavBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(201)))));
            this.PanelNavBar.Location = new System.Drawing.Point(0, 0);
            this.PanelNavBar.Name = "PanelNavBar";
            this.PanelNavBar.Size = new System.Drawing.Size(220, 650);
            this.PanelNavBar.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(7, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(169)))), ((int)(((byte)(58)))));
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(92)))));
            this.buttonMinimize.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.buttonMinimize.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonMinimize.Location = new System.Drawing.Point(622, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimize.TabIndex = 6;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(92)))));
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(92)))));
            this.buttonClose.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.buttonClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.buttonClose.ImageOffset = new System.Drawing.Point(1, 1);
            this.buttonClose.ImageSize = new System.Drawing.Size(15, 15);
            this.buttonClose.Location = new System.Drawing.Point(648, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelWindowControl
            // 
            this.panelWindowControl.Controls.Add(this.buttonClose);
            this.panelWindowControl.Controls.Add(this.buttonMinimize);
            this.panelWindowControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowControl.Location = new System.Drawing.Point(220, 0);
            this.panelWindowControl.Name = "panelWindowControl";
            this.panelWindowControl.Size = new System.Drawing.Size(680, 40);
            this.panelWindowControl.TabIndex = 7;
            // 
            // pictureBoxLogoName
            // 
            this.pictureBoxLogoName.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoName.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoName.Image")));
            this.pictureBoxLogoName.Location = new System.Drawing.Point(62, 17);
            this.pictureBoxLogoName.Name = "pictureBoxLogoName";
            this.pictureBoxLogoName.Size = new System.Drawing.Size(145, 40);
            this.pictureBoxLogoName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoName.TabIndex = 1;
            this.pictureBoxLogoName.TabStop = false;
            // 
            // PanelNavBarLogo
            // 
            this.PanelNavBarLogo.BackColor = System.Drawing.Color.Transparent;
            this.PanelNavBarLogo.Controls.Add(this.pictureBoxLogoName);
            this.PanelNavBarLogo.Controls.Add(this.pictureBoxLogo);
            this.PanelNavBarLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNavBarLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelNavBarLogo.Name = "PanelNavBarLogo";
            this.PanelNavBarLogo.Size = new System.Drawing.Size(220, 161);
            this.PanelNavBarLogo.TabIndex = 0;
            // 
            // panelNavButtons
            // 
            this.panelNavButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelNavButtons.Controls.Add(this.buttonEmployee);
            this.panelNavButtons.Controls.Add(this.guna2GradientButton6);
            this.panelNavButtons.Controls.Add(this.buttonLogout);
            this.panelNavButtons.Controls.Add(this.buttonSupplier);
            this.panelNavButtons.Controls.Add(this.buttonDispence);
            this.panelNavButtons.Controls.Add(this.buttonMedicine);
            this.panelNavButtons.Controls.Add(this.buttonDashboard);
            this.panelNavButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavButtons.Location = new System.Drawing.Point(0, 161);
            this.panelNavButtons.Name = "panelNavButtons";
            this.panelNavButtons.Size = new System.Drawing.Size(220, 489);
            this.panelNavButtons.TabIndex = 1;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDashboard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FillColor = System.Drawing.Color.Empty;
            this.buttonDashboard.FillColor2 = System.Drawing.Color.Empty;
            this.buttonDashboard.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(181)))), ((int)(((byte)(224)))));
            this.buttonDashboard.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(201)))));
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonDashboard.ImageOffset = new System.Drawing.Point(15, 0);
            this.buttonDashboard.Location = new System.Drawing.Point(0, 0);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(220, 45);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonDashboard.TextOffset = new System.Drawing.Point(30, 0);
            this.buttonDashboard.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // buttonMedicine
            // 
            this.buttonMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMedicine.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMedicine.FillColor = System.Drawing.Color.Empty;
            this.buttonMedicine.FillColor2 = System.Drawing.Color.Empty;
            this.buttonMedicine.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicine.ForeColor = System.Drawing.Color.White;
            this.buttonMedicine.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(181)))), ((int)(((byte)(224)))));
            this.buttonMedicine.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(201)))));
            this.buttonMedicine.Image = ((System.Drawing.Image)(resources.GetObject("buttonMedicine.Image")));
            this.buttonMedicine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonMedicine.ImageOffset = new System.Drawing.Point(15, 0);
            this.buttonMedicine.Location = new System.Drawing.Point(0, 45);
            this.buttonMedicine.Name = "buttonMedicine";
            this.buttonMedicine.Size = new System.Drawing.Size(220, 45);
            this.buttonMedicine.TabIndex = 2;
            this.buttonMedicine.Text = "Medicine";
            this.buttonMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonMedicine.TextOffset = new System.Drawing.Point(30, 0);
            this.buttonMedicine.Click += new System.EventHandler(this.buttonMedicine_Click);
            // 
            // buttonDispence
            // 
            this.buttonDispence.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDispence.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDispence.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDispence.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDispence.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDispence.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDispence.FillColor = System.Drawing.Color.Empty;
            this.buttonDispence.FillColor2 = System.Drawing.Color.Empty;
            this.buttonDispence.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDispence.ForeColor = System.Drawing.Color.White;
            this.buttonDispence.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(181)))), ((int)(((byte)(224)))));
            this.buttonDispence.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(201)))));
            this.buttonDispence.Image = ((System.Drawing.Image)(resources.GetObject("buttonDispence.Image")));
            this.buttonDispence.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonDispence.ImageOffset = new System.Drawing.Point(15, 0);
            this.buttonDispence.Location = new System.Drawing.Point(0, 90);
            this.buttonDispence.Name = "buttonDispence";
            this.buttonDispence.Size = new System.Drawing.Size(220, 45);
            this.buttonDispence.TabIndex = 3;
            this.buttonDispence.Text = "Dispense";
            this.buttonDispence.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonDispence.TextOffset = new System.Drawing.Point(30, 0);
            this.buttonDispence.Click += new System.EventHandler(this.buttonDispence_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSupplier.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSupplier.FillColor = System.Drawing.Color.Empty;
            this.buttonSupplier.FillColor2 = System.Drawing.Color.Empty;
            this.buttonSupplier.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplier.ForeColor = System.Drawing.Color.White;
            this.buttonSupplier.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(181)))), ((int)(((byte)(224)))));
            this.buttonSupplier.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(201)))));
            this.buttonSupplier.Image = ((System.Drawing.Image)(resources.GetObject("buttonSupplier.Image")));
            this.buttonSupplier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonSupplier.ImageOffset = new System.Drawing.Point(15, 0);
            this.buttonSupplier.Location = new System.Drawing.Point(0, 135);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(220, 45);
            this.buttonSupplier.TabIndex = 4;
            this.buttonSupplier.Text = "Supplier";
            this.buttonSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonSupplier.TextOffset = new System.Drawing.Point(30, 0);
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(89)))), ((int)(((byte)(150)))));
            this.buttonLogout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(89)))), ((int)(((byte)(150)))));
            this.buttonLogout.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.buttonLogout.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonLogout.ImageOffset = new System.Drawing.Point(15, 0);
            this.buttonLogout.Location = new System.Drawing.Point(0, 410);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(220, 45);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonLogout.TextOffset = new System.Drawing.Point(30, 0);
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.guna2GradientButton6.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.guna2GradientButton6.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.guna2GradientButton6.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton6.Image")));
            this.guna2GradientButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton6.ImageOffset = new System.Drawing.Point(15, 0);
            this.guna2GradientButton6.Location = new System.Drawing.Point(0, 365);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.Size = new System.Drawing.Size(220, 45);
            this.guna2GradientButton6.TabIndex = 6;
            this.guna2GradientButton6.Text = "Settings";
            this.guna2GradientButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton6.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(220, 40);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(680, 610);
            this.panelContainer.TabIndex = 8;
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEmployee.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployee.FillColor = System.Drawing.Color.Empty;
            this.buttonEmployee.FillColor2 = System.Drawing.Color.Empty;
            this.buttonEmployee.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonEmployee.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(181)))), ((int)(((byte)(224)))));
            this.buttonEmployee.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(201)))));
            this.buttonEmployee.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployee.Image")));
            this.buttonEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonEmployee.ImageOffset = new System.Drawing.Point(15, 0);
            this.buttonEmployee.Location = new System.Drawing.Point(0, 180);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(220, 45);
            this.buttonEmployee.TabIndex = 7;
            this.buttonEmployee.Text = "Employee";
            this.buttonEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonEmployee.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // FormDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelWindowControl);
            this.Controls.Add(this.PanelNavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashbord";
            this.Load += new System.EventHandler(this.FormDashbord_Load);
            this.PanelNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelWindowControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoName)).EndInit();
            this.PanelNavBarLogo.ResumeLayout(false);
            this.panelNavButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseFormDashbord;
        private Guna.UI2.WinForms.Guna2DragControl DragControlFormDashboard;
        private Guna.UI2.WinForms.Guna2Panel PanelNavBar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Guna.UI2.WinForms.Guna2Panel panelWindowControl;
        private Guna.UI2.WinForms.Guna2CircleButton buttonClose;
        private Guna.UI2.WinForms.Guna2CircleButton buttonMinimize;
        private System.Windows.Forms.PictureBox pictureBoxLogoName;
        private Guna.UI2.WinForms.Guna2Panel PanelNavBarLogo;
        private System.Windows.Forms.Panel panelNavButtons;
        private Guna.UI2.WinForms.Guna2GradientButton buttonDashboard;
        private Guna.UI2.WinForms.Guna2GradientButton buttonDispence;
        private Guna.UI2.WinForms.Guna2GradientButton buttonMedicine;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2GradientButton buttonLogout;
        private Guna.UI2.WinForms.Guna2GradientButton buttonSupplier;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private Guna.UI2.WinForms.Guna2GradientButton buttonEmployee;
    }
}