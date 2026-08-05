using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    internal class CurrentUser
    {
        //using static variable because only one user will use the system at a time
        //so that means only one user actively uses the system
        //so no need of creating objects
        private static string currentUser;

        public static string getSetCurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public bool login(string inputUsername, string inputPassword)
        {
            try
            {
                bool loginSuccessful = false;

                string sql = "SELECT Username,Password,EmployeeID,Role FROM Employee WHERE Username = '" + inputUsername + "'  AND IsVisible = 1";

                DBConnection DBObj = new DBConnection();
                SqlCommand comObj = new SqlCommand(sql, DBObj.connect());
                //making a reader
                SqlDataReader reader = comObj.ExecuteReader();
                //if data exist to the qurey 
                if (reader.Read())
                {
                    //getting username and password from db to check
                    string dbUsername = reader["Username"].ToString();
                    string dbPassword = reader["Password"].ToString();
                    //getting employee ID for current user
                    string dbEmployeeID = reader["EmployeeID"].ToString();


                    //check user name and password matches
                    if (inputUsername == dbUsername && inputPassword == dbPassword)
                    {
                        //saving EmployeeID as currentUser in the static variable
                        currentUser = dbEmployeeID;
                        //if username and passwords is correct -> login successful
                        loginSuccessful = true;
                    }

                }
                DBObj.disconnect();
                return loginSuccessful;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
                return false;
            }

        }

        public void logout()
        {
            try
            {
                //removing current user details
                //removing values from static variables
                currentUser = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        public bool checkUsernameAvailablity(string username)
        {
            bool usernameAvailable = true;

            //to check user enterd username already exsits
            string sql = "SELECT * FROM Employee WHERE Username = '"+username+"'";
            DBConnection DBObj = new DBConnection();
            SqlCommand comObj = new SqlCommand(sql, DBObj.connect());
            SqlDataReader reader = comObj.ExecuteReader();
            //first check if its empty or not
            if (reader.Read())
            {
                usernameAvailable = false;
            }
            DBObj.disconnect();
            return usernameAvailable;
        }

        public string checkRole()
        {
            try
            {
                bool loginSuccessful = false;

                string sql = "SELECT Role FROM Employee WHERE EmployeeID = '" + currentUser + "'  AND IsVisible = 1";

                DBConnection DBObj = new DBConnection();
                SqlCommand comObj = new SqlCommand(sql, DBObj.connect());
                //making a reader
                SqlDataReader reader = comObj.ExecuteReader();
                reader.Read();

                string role = reader["Role"].ToString();

                DBObj.disconnect();

                return role;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
                return "staff";                
            }
        }
    }
}
