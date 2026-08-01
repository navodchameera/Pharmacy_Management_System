namespace PharmacyManagementSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.ElipseFormLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControlFormLogin = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelWindowControl = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelWelcomeTab = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelLoginTab = new Guna.UI2.WinForms.Guna2Panel();
            this.labelErrorPassword = new System.Windows.Forms.Label();
            this.labelErrorUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonHidePassword = new Guna.UI2.WinForms.Guna2Button();
            this.buttonShowPassword = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsername = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTipFormLogin = new System.Windows.Forms.ToolTip(this.components);
            this.panelWindowControl.SuspendLayout();
            this.panelWelcomeTab.SuspendLayout();
            this.panelLoginTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseFormLogin
            // 
            this.ElipseFormLogin.BorderRadius = 30;
            this.ElipseFormLogin.TargetControl = this;
            // 
            // DragControlFormLogin
            // 
            this.DragControlFormLogin.DockIndicatorTransparencyValue = 0.6D;
            this.DragControlFormLogin.TargetControl = this.panelWindowControl;
            this.DragControlFormLogin.UseTransparentDrag = true;
            // 
            // panelWindowControl
            // 
            this.panelWindowControl.Controls.Add(this.buttonMinimize);
            this.panelWindowControl.Controls.Add(this.buttonClose);
            this.panelWindowControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowControl.Location = new System.Drawing.Point(0, 0);
            this.panelWindowControl.Margin = new System.Windows.Forms.Padding(2);
            this.panelWindowControl.Name = "panelWindowControl";
            this.panelWindowControl.Size = new System.Drawing.Size(900, 53);
            this.panelWindowControl.TabIndex = 2;
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
            this.buttonMinimize.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonMinimize.Location = new System.Drawing.Point(842, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimize.TabIndex = 4;
            this.toolTipFormLogin.SetToolTip(this.buttonMinimize, "Minimize Application");
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
            this.buttonClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.buttonClose.ImageOffset = new System.Drawing.Point(1, 1);
            this.buttonClose.ImageSize = new System.Drawing.Size(15, 15);
            this.buttonClose.Location = new System.Drawing.Point(868, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 2;
            this.toolTipFormLogin.SetToolTip(this.buttonClose, "Close Application");
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelWelcomeTab
            // 
            this.panelWelcomeTab.BackColor = System.Drawing.Color.Transparent;
            this.panelWelcomeTab.BorderRadius = 20;
            this.panelWelcomeTab.Controls.Add(this.panelLoginTab);
            this.panelWelcomeTab.Controls.Add(this.pictureBox3);
            this.panelWelcomeTab.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.panelWelcomeTab.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(154)))), ((int)(((byte)(214)))));
            this.panelWelcomeTab.Location = new System.Drawing.Point(131, 81);
            this.panelWelcomeTab.Margin = new System.Windows.Forms.Padding(2);
            this.panelWelcomeTab.Name = "panelWelcomeTab";
            this.panelWelcomeTab.Size = new System.Drawing.Size(638, 488);
            this.panelWelcomeTab.TabIndex = 3;
            // 
            // panelLoginTab
            // 
            this.panelLoginTab.BorderRadius = 20;
            this.panelLoginTab.Controls.Add(this.labelErrorPassword);
            this.panelLoginTab.Controls.Add(this.labelErrorUsername);
            this.panelLoginTab.Controls.Add(this.textBoxUsername);
            this.panelLoginTab.Controls.Add(this.buttonHidePassword);
            this.panelLoginTab.Controls.Add(this.buttonShowPassword);
            this.panelLoginTab.Controls.Add(this.pictureBoxPassword);
            this.panelLoginTab.Controls.Add(this.pictureBoxUsername);
            this.panelLoginTab.Controls.Add(this.buttonLogin);
            this.panelLoginTab.Controls.Add(this.labelPassword);
            this.panelLoginTab.Controls.Add(this.labelUsername);
            this.panelLoginTab.Controls.Add(this.labelLogin);
            this.panelLoginTab.Controls.Add(this.textBoxPassword);
            this.panelLoginTab.FillColor = System.Drawing.SystemColors.ControlLight;
            this.panelLoginTab.Location = new System.Drawing.Point(311, 8);
            this.panelLoginTab.Margin = new System.Windows.Forms.Padding(2);
            this.panelLoginTab.Name = "panelLoginTab";
            this.panelLoginTab.Size = new System.Drawing.Size(319, 471);
            this.panelLoginTab.TabIndex = 0;
            // 
            // labelErrorPassword
            // 
            this.labelErrorPassword.AutoSize = true;
            this.labelErrorPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPassword.Location = new System.Drawing.Point(55, 335);
            this.labelErrorPassword.Name = "labelErrorPassword";
            this.labelErrorPassword.Size = new System.Drawing.Size(165, 15);
            this.labelErrorPassword.TabIndex = 13;
            this.labelErrorPassword.Text = "* Password can not be empty";
            // 
            // labelErrorUsername
            // 
            this.labelErrorUsername.AutoSize = true;
            this.labelErrorUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.labelErrorUsername.Location = new System.Drawing.Point(51, 234);
            this.labelErrorUsername.Name = "labelErrorUsername";
            this.labelErrorUsername.Size = new System.Drawing.Size(169, 15);
            this.labelErrorUsername.TabIndex = 12;
            this.labelErrorUsername.Text = "* Username can not be empty";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.textBoxUsername.BorderRadius = 8;
            this.textBoxUsername.BorderThickness = 2;
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.DefaultText = "";
            this.textBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.Location = new System.Drawing.Point(49, 192);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PlaceholderText = "Username";
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(226, 40);
            this.textBoxUsername.TabIndex = 8;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // buttonHidePassword
            // 
            this.buttonHidePassword.BackColor = System.Drawing.Color.White;
            this.buttonHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHidePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHidePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHidePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHidePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHidePassword.FillColor = System.Drawing.Color.Transparent;
            this.buttonHidePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHidePassword.ForeColor = System.Drawing.Color.White;
            this.buttonHidePassword.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.buttonHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonHidePassword.Image")));
            this.buttonHidePassword.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonHidePassword.Location = new System.Drawing.Point(242, 302);
            this.buttonHidePassword.Name = "buttonHidePassword";
            this.buttonHidePassword.PressedDepth = 0;
            this.buttonHidePassword.Size = new System.Drawing.Size(25, 25);
            this.buttonHidePassword.TabIndex = 10;
            this.toolTipFormLogin.SetToolTip(this.buttonHidePassword, "Hide Password");
            this.buttonHidePassword.Click += new System.EventHandler(this.buttonHidePassword_Click);
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.BackColor = System.Drawing.Color.White;
            this.buttonShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonShowPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonShowPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonShowPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonShowPassword.FillColor = System.Drawing.Color.Transparent;
            this.buttonShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonShowPassword.ForeColor = System.Drawing.Color.White;
            this.buttonShowPassword.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.buttonShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowPassword.Image")));
            this.buttonShowPassword.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonShowPassword.Location = new System.Drawing.Point(242, 302);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.PressedDepth = 0;
            this.buttonShowPassword.Size = new System.Drawing.Size(25, 25);
            this.buttonShowPassword.TabIndex = 8;
            this.toolTipFormLogin.SetToolTip(this.buttonShowPassword, "Show Password");
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(49, 274);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 9;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUsername
            // 
            this.pictureBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsername.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsername.Image")));
            this.pictureBoxUsername.Location = new System.Drawing.Point(49, 170);
            this.pictureBoxUsername.Name = "pictureBoxUsername";
            this.pictureBoxUsername.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsername.TabIndex = 8;
            this.pictureBoxUsername.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BorderRadius = 10;
            this.buttonLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(154)))), ((int)(((byte)(214)))));
            this.buttonLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.buttonLogin.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.buttonLogin.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(154)))), ((int)(((byte)(214)))));
            this.buttonLogin.Location = new System.Drawing.Point(94, 378);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(139, 37);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.labelPassword.Location = new System.Drawing.Point(67, 271);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 21);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.labelUsername.Image = ((System.Drawing.Image)(resources.GetObject("labelUsername.Image")));
            this.labelUsername.Location = new System.Drawing.Point(67, 167);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 21);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.labelLogin.Location = new System.Drawing.Point(76, 59);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(176, 65);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "LOGIN";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.textBoxPassword.BorderRadius = 8;
            this.textBoxPassword.BorderThickness = 2;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.Location = new System.Drawing.Point(49, 296);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.PlaceholderText = "Password";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(226, 36);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 300);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelWelcomeTab);
            this.Controls.Add(this.panelWindowControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelWindowControl.ResumeLayout(false);
            this.panelWelcomeTab.ResumeLayout(false);
            this.panelLoginTab.ResumeLayout(false);
            this.panelLoginTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseFormLogin;
        private Guna.UI2.WinForms.Guna2DragControl DragControlFormLogin;
        private Guna.UI2.WinForms.Guna2Panel panelWindowControl;
        private Guna.UI2.WinForms.Guna2CircleButton buttonMinimize;
        private Guna.UI2.WinForms.Guna2CircleButton buttonClose;
        private Guna.UI2.WinForms.Guna2GradientPanel panelWelcomeTab;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private Guna.UI2.WinForms.Guna2Panel panelLoginTab;
        private Guna.UI2.WinForms.Guna2Button buttonHidePassword;
        private Guna.UI2.WinForms.Guna2Button buttonShowPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxUsername;
        private Guna.UI2.WinForms.Guna2GradientButton buttonLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private System.Windows.Forms.ToolTip toolTipFormLogin;
        private System.Windows.Forms.Label labelErrorPassword;
        private System.Windows.Forms.Label labelErrorUsername;
    }
}

