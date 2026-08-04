using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    internal class CurrentUser
    {
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
    }
}
