using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            //clear the textbox
            textBoxNewUsername.Text = "";
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

            //claer textboxes
            textBoxCurrentPassword.Text = "";
            textBoxNewPassword.Text = "";
            textBoxConfirmNewPassword.Text = "";
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

        private void buttonChangeUsername_Click(object sender, EventArgs e)
        {
            try
            {
                //to check username and current user id
                CurrentUser userObj = new CurrentUser();

                //checks new username is empty when button is pressed
                //if it is
                if (textBoxNewUsername.Text.Trim() == "")
                {
                    labelErrorUsername.Text = "*Username can not be empty";
                    labelErrorUsername.Show();
                }
                //check username availability
                else if (userObj.checkUsernameAvailablity(textBoxNewUsername.Text.Trim()))
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to change the username?",
                        "Confirm Username Change",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        //if user choses yes
                        string sql = "UPDATE Employee SET Username = '" + textBoxNewUsername.Text.Trim() + "' " +
                        "WHERE EmployeeID = '" + CurrentUser.getSetCurrentUser + "'";
                        DBConnection dbObj = new DBConnection();
                        SqlCommand comObj = new SqlCommand(sql, dbObj.connect());
                        comObj.ExecuteNonQuery();

                        MessageBox.Show(
                        "Username updated successfully." +
                        "\n\nPlease make sure to remember your new username, as it is required to log in to your account.",
                        "Success"
                        );

                        dbObj.disconnect();
                        //clear the textbox
                        textBoxNewUsername.Text = "";
                    }
                    
                }
                else
                {
                    labelErrorUsername.Text = "*Username already exists. Try a another one";
                    labelErrorUsername.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                //if currentpassword is empty show error label
                if (textBoxCurrentPassword.Text == "")
                {
                    labelErrorCurrentPassword.Show();
                }
                //if new password is empty show error label
                if (textBoxNewPassword.Text == "")
                {
                    labelErrorNewPassword.Show();
                }
                //if confirm new password is empty show error label
                if (textBoxConfirmNewPassword.Text == "")
                {
                    labelErrorConfirmPassword.Text = "*This can not be Empty";
                    labelErrorConfirmPassword.Show();
                }

                //if every thing is NOT empty
                if (textBoxCurrentPassword.Text != "" && textBoxNewPassword.Text != "" && textBoxConfirmNewPassword.Text != "")
                {
                    //confirming user wants to update the password
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to update your password?",
                        "Confirm Password Update",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    //if user says yes
                    if (result == DialogResult.Yes)
                    {
                        //getting user enterd current password to check if it matches with the db password
                        string inputCurrentPassword = textBoxCurrentPassword.Text;

                        //get current users db stored password
                        string sql = "SELECT Password FROM Employee WHERE EmployeeID = '" + CurrentUser.getSetCurrentUser + "'";
                        DBConnection dbObj = new DBConnection();
                        SqlCommand comObj = new SqlCommand(sql, dbObj.connect());
                        SqlDataReader reader = comObj.ExecuteReader();
                        reader.Read();

                        //getting db password to a varibale
                        string dbPassword = reader["Password"].ToString();

                        //if current password and db passwrod matches and new password and confirm password matches
                        if (inputCurrentPassword == dbPassword && textBoxNewPassword.Text == textBoxConfirmNewPassword.Text)
                        {
                            string changePasswordSql = "UPDATE Employee SET Password = '" + textBoxNewPassword.Text + "' " +
                                "WHERE EmployeeID = '" + CurrentUser.getSetCurrentUser + "';";
                            SqlCommand changePasswordCom = new SqlCommand(changePasswordSql, dbObj.connect());
                            changePasswordCom.ExecuteNonQuery();

                            //shows it updated successfully 
                            MessageBox.Show("Password updated successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Current password is incorrect.", "Invalid Password",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        dbObj.disconnect();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void textBoxNewUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewUsername.Text.Trim() != "")
            {
                labelErrorUsername.Hide();
            }
            
        }
        //if user types something and text box is not empty hide the error
        private void textBoxCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCurrentPassword.Text != "")
            { 
                labelErrorCurrentPassword.Hide();
            }
        }
        //if user types something and text box is not empty hide the error
        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text != "")
            {
                labelErrorNewPassword.Hide();
            }
        }

        private void textBoxConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            
            //show error passwords does not match
            if (textBoxNewPassword.Text != textBoxConfirmNewPassword.Text)
            {
                labelErrorConfirmPassword.Text = "*New Passwords does not match";
                labelErrorConfirmPassword.Show();
            }
            else 
            { 
                labelErrorConfirmPassword.Hide(); 
            }
        }

        
    }
}
