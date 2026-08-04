using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class FormDashbord : Form
    {
        public FormDashbord()
        {
            InitializeComponent();
        }

        private void FormDashbord_Load(object sender, EventArgs e)
        {
            //load user control dashbord
            LoadControl(new UserControlDashboard());
            //highlight the dashboard button
            buttonDashboard.FillColor = Color.FromArgb(165, 207, 235);
            buttonDashboard.FillColor2 = Color.FromArgb(165, 207, 235);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //get user input whether user wants to close the app or not
            DialogResult result = MessageBox.Show(
            "Are you sure you want to exit the application?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // if user presses yes close the application
                Application.Exit();
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            //minimize the window
            this.WindowState = FormWindowState.Minimized;
        }

        //log oout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to log out?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Close the dashboard form and show login again
                this.Hide();
                FormLogin logout = new FormLogin();
                logout.Show();
            }
        }

        //this holds the all the panels(user controls) and load them
        private void LoadControl(UserControl control)
        {
            panelContainer.SuspendLayout();
            panelContainer.Controls.Clear(); //removes current panel to load the new one

            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control); //loads the new panel to the panel container
            panelContainer.ResumeLayout();
        }

        //load the panel dashboard to(user Control) the dashboard
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            //to hightlight that it is selected
            buttonDashboard.FillColor = Color.FromArgb(165, 207, 235);
            buttonDashboard.FillColor2 = Color.FromArgb(165, 207, 235);

            //change others to normal colour
            buttonMedicine.FillColor = Color.Transparent;
            buttonMedicine.FillColor2 = Color.Transparent;

            buttonDispence.FillColor = Color.Transparent;
            buttonDispence.FillColor2 = Color.Transparent;

            buttonSupplier.FillColor = Color.Transparent;
            buttonSupplier.FillColor2 = Color.Transparent;

            buttonEmployee.FillColor = Color.Transparent;
            buttonEmployee.FillColor2 = Color.Transparent;

            buttonSettings.FillColor = Color.Transparent;
            buttonSettings.FillColor2 = Color.Transparent;

            LoadControl(new UserControlDashboard());
        }

        private void buttonMedicine_Click(object sender, EventArgs e)
        {
            //to hightlight that it is selected
            buttonMedicine.FillColor = Color.FromArgb(165, 207, 235);
            buttonMedicine.FillColor2 = Color.FromArgb(165, 207, 235);

            //change others to normal colour
            buttonDashboard.FillColor = Color.Transparent;
            buttonDashboard.FillColor2 = Color.Transparent;

            buttonDispence.FillColor = Color.Transparent;
            buttonDispence.FillColor2 = Color.Transparent;

            buttonSupplier.FillColor = Color.Transparent;
            buttonSupplier.FillColor2 = Color.Transparent;

            buttonEmployee.FillColor = Color.Transparent;
            buttonEmployee.FillColor2 = Color.Transparent;

            buttonSettings.FillColor = Color.Transparent;
            buttonSettings.FillColor2 = Color.Transparent;

            LoadControl(new UserControlMedicine());
        }

        private void buttonDispence_Click(object sender, EventArgs e)
        {
            //to hightlight that it is selected
            buttonDispence.FillColor = Color.FromArgb(165, 207, 235);
            buttonDispence.FillColor2 = Color.FromArgb(165, 207, 235);

            //change others to normal colour
            buttonDashboard.FillColor = Color.Transparent;
            buttonDashboard.FillColor2 = Color.Transparent;

            buttonMedicine.FillColor = Color.Transparent;
            buttonMedicine.FillColor2 = Color.Transparent;

            buttonSupplier.FillColor = Color.Transparent;
            buttonSupplier.FillColor2 = Color.Transparent;

            buttonEmployee.FillColor = Color.Transparent;
            buttonEmployee.FillColor2 = Color.Transparent;

            buttonSettings.FillColor = Color.Transparent;
            buttonSettings.FillColor2 = Color.Transparent;

            LoadControl(new UserControldispense());
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            //to hightlight that it is selected
            buttonSupplier.FillColor = Color.FromArgb(165, 207, 235);
            buttonSupplier.FillColor2 = Color.FromArgb(165, 207, 235);

            //change others to normal colour
            buttonDashboard.FillColor = Color.Transparent;
            buttonDashboard.FillColor2 = Color.Transparent;

            buttonMedicine.FillColor = Color.Transparent;
            buttonMedicine.FillColor2 = Color.Transparent;

            buttonDispence.FillColor = Color.Transparent;
            buttonDispence.FillColor2 = Color.Transparent;

            buttonEmployee.FillColor = Color.Transparent;
            buttonEmployee.FillColor2 = Color.Transparent;

            buttonSettings.FillColor = Color.Transparent;
            buttonSettings.FillColor2 = Color.Transparent;

        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            //to hightlight that it is selected
            buttonEmployee.FillColor = Color.FromArgb(165, 207, 235);
            buttonEmployee.FillColor2 = Color.FromArgb(165, 207, 235);


            //change others to normal colour
            buttonDashboard.FillColor = Color.Transparent;
            buttonDashboard.FillColor2 = Color.Transparent;

            buttonMedicine.FillColor = Color.Transparent;
            buttonMedicine.FillColor2 = Color.Transparent;

            buttonDispence.FillColor = Color.Transparent;
            buttonDispence.FillColor2 = Color.Transparent;

            buttonSupplier.FillColor = Color.Transparent;
            buttonSupplier.FillColor2 = Color.Transparent;

            buttonSettings.FillColor = Color.Transparent;
            buttonSettings.FillColor2 = Color.Transparent;

            LoadControl(new UserControlEmployee());
            
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            //to hightlight that it is selected
            buttonSettings.FillColor = Color.FromArgb(165, 207, 235);
            buttonSettings.FillColor2 = Color.FromArgb(165, 207, 235);


            //change others to normal colour
            buttonDashboard.FillColor = Color.Transparent;
            buttonDashboard.FillColor2 = Color.Transparent;

            buttonMedicine.FillColor = Color.Transparent;
            buttonMedicine.FillColor2 = Color.Transparent;

            buttonDispence.FillColor = Color.Transparent;
            buttonDispence.FillColor2 = Color.Transparent;

            buttonSupplier.FillColor = Color.Transparent;
            buttonSupplier.FillColor2 = Color.Transparent;

            buttonEmployee.FillColor = Color.Transparent;
            buttonEmployee.FillColor2 = Color.Transparent;

            LoadControl(new UserControlSettings());
        }

        
    }
}
