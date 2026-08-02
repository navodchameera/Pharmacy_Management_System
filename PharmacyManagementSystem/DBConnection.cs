using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem
{
    internal class DBConnection
    {
        
        string connectionString = "Data Source = DESKTOP-7KOHJPG; Initial Catalog=PharmacyManagementSystem; Integrated Security=True";
        SqlConnection connObj;

        public SqlConnection connect()
        { 
            connObj = new SqlConnection(connectionString);
            connObj.Open();
            return connObj;
        }

        public void disconnect()
        { 
            connObj.Close();
        }
    }
}
