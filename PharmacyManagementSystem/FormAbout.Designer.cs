namespace PharmacyManagementSystem
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.ElipseFormAbout = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControlFormAbout = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelWindowControl = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelAbout = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelSystemName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelWindowControl.SuspendLayout();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseFormAbout
            // 
            this.ElipseFormAbout.BorderRadius = 30;
            this.ElipseFormAbout.TargetControl = this;
            // 
            // DragControlFormAbout
            // 
            this.DragControlFormAbout.DockIndicatorTransparencyValue = 0.6D;
            this.DragControlFormAbout.TargetControl = this.panelWindowControl;
            this.DragControlFormAbout.UseTransparentDrag = true;
            // 
            // panelWindowControl
            // 
            this.panelWindowControl.Controls.Add(this.buttonClose);
            this.panelWindowControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowControl.Location = new System.Drawing.Point(0, 0);
            this.panelWindowControl.Name = "panelWindowControl";
            this.panelWindowControl.Size = new System.Drawing.Size(400, 40);
            this.panelWindowControl.TabIndex = 0;
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
            this.buttonClose.Location = new System.Drawing.Point(368, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonClose.Size = new System.Drawing.Size(20, 20);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.BorderRadius = 20;
            this.panelAbout.Controls.Add(this.label4);
            this.panelAbout.Controls.Add(this.labelDeveloper);
            this.panelAbout.Controls.Add(this.labelVersion);
            this.panelAbout.Controls.Add(this.labelSystemName);
            this.panelAbout.Controls.Add(this.pictureBoxLogo);
            this.panelAbout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(109)))), ((int)(((byte)(184)))));
            this.panelAbout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(154)))), ((int)(((byte)(214)))));
            this.panelAbout.Location = new System.Drawing.Point(25, 54);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(350, 325);
            this.panelAbout.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(100, -12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelSystemName
            // 
            this.labelSystemName.AutoSize = true;
            this.labelSystemName.BackColor = System.Drawing.Color.Transparent;
            this.labelSystemName.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemName.ForeColor = System.Drawing.Color.White;
            this.labelSystemName.Location = new System.Drawing.Point(62, 140);
            this.labelSystemName.Name = "labelSystemName";
            this.labelSystemName.Size = new System.Drawing.Size(230, 21);
            this.labelSystemName.TabIndex = 1;
            this.labelSystemName.Text = "Pharmacy Management System";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Leelawadee UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(143, 162);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(64, 13);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Version 1.0";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.BackColor = System.Drawing.Color.Transparent;
            this.labelDeveloper.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloper.ForeColor = System.Drawing.Color.White;
            this.labelDeveloper.Location = new System.Drawing.Point(118, 201);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(115, 38);
            this.labelDeveloper.TabIndex = 3;
            this.labelDeveloper.Text = "Developed By\r\nNavod Chameera";
            this.labelDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Built with \r\nC#, .NET framework, winForms, \r\nGuna UI2 Nuget Package";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelWindowControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            this.panelWindowControl.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseFormAbout;
        private Guna.UI2.WinForms.Guna2DragControl DragControlFormAbout;
        private Guna.UI2.WinForms.Guna2Panel panelWindowControl;
        private Guna.UI2.WinForms.Guna2CircleButton buttonClose;
        private Guna.UI2.WinForms.Guna2GradientPanel panelAbout;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelSystemName;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label4;
    }
}