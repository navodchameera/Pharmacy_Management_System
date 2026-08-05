using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            loadPurchaseHistoryDGV();
            loadLowStockDGV();
            loadExpiryItemsDGV();
        }

        public void loadPurchaseHistoryDGV()
        {
            string sql = "SELECT Orders.OrderID AS [Order ID], " +
                "Customer.CustomerName AS [Customer Name], " +
                "Employee.EmployeeName AS [Employee Name], " +
                "Orders.OrderDate AS [Order Date], " +
                "Orders.TotalAmount AS [Total Amount], " +
                "Orders.Discount AS [Discount] " +
                "FROM Orders JOIN Customer ON Orders.CustomerID = Customer.CustomerID" +
                " JOIN Employee ON Orders.EmployeeID = Employee.EmployeeID " +
                "WHERE Orders.IsVisible = 1 ORDER BY Orders.OrderDate DESC;";

            DBConnection dbObj = new DBConnection();
            SqlCommand comObj = new SqlCommand(sql, dbObj.connect());
            SqlDataAdapter adapter = new SqlDataAdapter(comObj);

            DataTable tbl =new DataTable();
            adapter.Fill(tbl);

            dataGridViewOrderHistory.DataSource = tbl;
            dbObj.disconnect();
        }

        public void loadLowStockDGV()
        {
            string sql = "SELECT MedicineID AS 'Medicine ID', " +
                "MedicineName AS 'Medicine Name', " +
                "Quantity AS 'Current Quantity', " +
                "LowStockWarning AS 'Low Stock Limit' " +
                "FROM Medicine WHERE IsVisible = 1 AND Quantity <= LowStockWarning";
            DBConnection dbObj = new DBConnection();
            SqlCommand comObj = new SqlCommand(sql, dbObj.connect());
            SqlDataAdapter adapter = new SqlDataAdapter(comObj);

            DataTable tbl = new DataTable();
            adapter.Fill(tbl);

            dataGridViewLowStock.DataSource = tbl;
            dbObj.disconnect();

            //loads count in to the label
            labelDisplayLowStockCount.Text = dataGridViewLowStock.Rows.Count.ToString();
        }

        public void loadExpiryItemsDGV()
        {
            string sql = "SELECT Medicine.MedicineName AS 'Medicine Name', " +
                "Restock.ExpiryDate AS 'Expiry Date' " +
                "FROM Medicine JOIN Restock ON Medicine.MedicineID = Restock.MedicineID " +
                "WHERE Restock.ExpiryDate <= DATEADD(MONTH, 3, GETDATE());";
            DBConnection dbObj = new DBConnection();
            SqlCommand comObj = new SqlCommand(sql, dbObj.connect());
            SqlDataAdapter adapter = new SqlDataAdapter(comObj);

            DataTable tbl = new DataTable();
            adapter.Fill(tbl);

            dataGridViewExpiryItems.DataSource = tbl;
            dbObj.disconnect();

            //loads count in to the label
            labelDisplayExpiryCount.Text = dataGridViewExpiryItems.Rows.Count.ToString();

        }
        
    }
}
