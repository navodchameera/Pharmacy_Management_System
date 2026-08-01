using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PharmacyManagementSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        
        private void FormLogin_Load(object sender, EventArgs e)
        {
            //when window is loading for the first time only show the password show button
            buttonShowPassword.Show();
            buttonHidePassword.Hide();

            //hide error providers in the start
            labelErrorUsername.Hide();
            labelErrorPassword.Hide();
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            //when show password is clicked hide the buttonShowPassword button and show the buttonHidePassword button 
            buttonShowPassword.Hide();
            buttonHidePassword.Show();

            //\0 turns password char in to normal text
            textBoxPassword.PasswordChar = '\0';
            
        }

        private void buttonHidePassword_Click(object sender, EventArgs e)
        {
            //when show password is clicked hide the buttonShowPassword button and show the buttonHidePassword button 
            buttonShowPassword.Show();
            buttonHidePassword.Hide();

            //turns password char in to ●
            textBoxPassword.PasswordChar = '●';
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //if user presses login without filling username show the error label
            //and removes the whitespace from beging and the end.
            if (textBoxUsername.Text.Trim() == "")
            {
                labelErrorUsername.Show();
            }

            //if user presses login without filling password show the error label
            if (textBoxPassword.Text == "")
            {
                labelErrorPassword.Show();
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            //if user types something in username(other than whitespace), hide the error label
            if (textBoxUsername.Text.Trim() != "")
            {
                labelErrorUsername.Hide();
            }
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            //if user types something in the password, hide the error label
            labelErrorPassword.Hide();
        }
    }
}
