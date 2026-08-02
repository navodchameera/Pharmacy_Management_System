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
    public partial class UserControlSettings : UserControl
    {
        public UserControlSettings()
        {
            InitializeComponent();
        }

        private void UserControlSettings_Load(object sender, EventArgs e)
        {
            //when user control load it should only load the change password expand button and without the change password panel
            buttonChangePasswordExpand.Show();
            buttonChangePasswordCollapse.Hide();
            panelChangePassword.Hide();
            //when user cotrol load hide the hidepassword button
            buttonHidePasswords.Hide();

            //when user control load it should only load the change username expand and without the change username panel
            buttonChangeUsernameExpand.Show();
            buttonChangeUsernameCollapse.Hide();
            panelChangeUsername.Hide();
            
        }

        private void buttonChangeUsernameExpand_Click(object sender, EventArgs e)
        {

            //show panel when user presses expand
            panelChangeUsername.Show();

            //hide expand button and show collapse button
            buttonChangeUsernameExpand.Hide();
            buttonChangeUsernameCollapse.Show();

        }

        private void buttonChangeUsernameCollapse_Click(object sender, EventArgs e)
        {

            //hide panel when user presses collapse
            panelChangeUsername.Hide();

            //hide collapse and show expand button
            buttonChangeUsernameExpand.Show();
            buttonChangeUsernameCollapse.Hide();
            

            
        }

        private void buttonChangePasswordExpand_Click(object sender, EventArgs e)
        {
            //show panel when user presses expand
            panelChangePassword.Show();

            //hide expand button and show collapse button
            buttonChangePasswordExpand.Hide();
            buttonChangePasswordCollapse.Show();
        }

        private void buttonChangePasswordCollapse_Click(object sender, EventArgs e)
        {
            //show panel when user presses expand
            panelChangePassword.Hide();

            //hide expand button and show collapse button
            buttonChangePasswordExpand.Show();
            buttonChangePasswordCollapse.Hide();
        }

        private void buttonShowPasswords_Click(object sender, EventArgs e)
        {
            //when show password is clicked hide the buttonShowPassword button and show the buttonHidePassword button 
            buttonShowPasswords.Hide();
            buttonHidePasswords.Show();

            //\0 turns password char in to normal text
            textBoxCurrentPassword.PasswordChar = '\0';
            textBoxNewPassword.PasswordChar = '\0';
            textBoxConfirmNewPassword.PasswordChar = '\0';
        }

        private void buttonHidePasswords_Click(object sender, EventArgs e)
        {
            //when show password is clicked hide the buttonShowPassword button and show the buttonHidePassword button 
            buttonShowPasswords.Show();
            buttonHidePasswords.Hide();

            //turns password char in to ●
            textBoxCurrentPassword.PasswordChar = '●';
            textBoxNewPassword.PasswordChar = '●';
            textBoxConfirmNewPassword.PasswordChar = '●';
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout loadAbout = new FormAbout();
            loadAbout.Show();
        }
    }
}
