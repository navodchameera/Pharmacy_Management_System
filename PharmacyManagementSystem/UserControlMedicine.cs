using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PharmacyManagementSystem
{
    public partial class UserControlMedicine : UserControl
    {
        public UserControlMedicine()
        {
            InitializeComponent();
        }

        private void UserControlMedicine_Load(object sender, EventArgs e)
        {
            buttonClearSearchBar.Hide();
            loadMedicineDGV();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text != "")
                {
                    buttonClearSearchBar.Show();
                    string sql = "SELECT MedicineID AS 'Medicine ID', MedicineName AS 'Medicine Name', " +
                        "Quantity AS 'Quantity', SellingPrice AS 'Selling Price', BuyingPrice AS 'Buying Price'," +
                        " LowStockWarning AS 'Low Stock Warning' " +
                        "FROM Medicine " +
                        "WHERE IsVisible = 1 AND (MedicineName LIKE '%"+textBoxSearch.Text+ "%' OR MedicineID LIKE '%"+textBoxSearch.Text+"%' )";
                    //creating a DBConnection object to call connect method
                    DBConnection DBObj = new DBConnection();
                    SqlCommand comObj = new SqlCommand(sql, DBObj.connect());

                    SqlDataAdapter adapter = new SqlDataAdapter(comObj);

                    //making a table to get values
                    DataTable tbl = new DataTable();
                    //filling the table with data
                    adapter.Fill(tbl);
                    //giving DVG data source
                    dataGridViewMedicine.DataSource = tbl;

                    //disconnet
                    DBObj.disconnect();
                }
                else
                {
                    buttonClearSearchBar.Hide();
                    loadMedicineDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonClearSearchBar_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.Focus();
        }

        //loads the whole table
        public void loadMedicineDGV()
        {
            try
            {
                string sql = "SELECT MedicineID AS 'Medicine ID', MedicineName AS 'Medicine Name'," +
                    " Quantity AS 'Quantity', SellingPrice AS 'Selling Price', BuyingPrice AS 'Buying Price'," +
                    " LowStockWarning AS 'Low Stock Warning' FROM Medicine WHERE IsVisible = 1";
                //creating a DBConnection object to call connect method
                DBConnection DBObj = new DBConnection();
                SqlCommand comObj = new SqlCommand(sql, DBObj.connect());

                SqlDataAdapter adapter = new SqlDataAdapter(comObj);

                //making a table to get values
                DataTable tbl = new DataTable();
                //filling the table with data
                adapter.Fill(tbl);
                //giving DVG data source
                dataGridViewMedicine.DataSource = tbl;
                //disconnect from database
                DBObj.disconnect();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
            
        }

        private void dataGridViewMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //checks users if user selected the table header.
                //if user clicked a table row
                if (e.RowIndex >= 0)
                {
                    //make the primary key uneditable
                    textBoxMedicineID.Enabled = false;

                    DataGridViewRow row = dataGridViewMedicine.Rows[e.RowIndex];

                    textBoxMedicineID.Text = row.Cells["Medicine ID"].Value.ToString();
                    textBoxMedicineName.Text = row.Cells["Medicine Name"].Value.ToString();
                    numericUpDownQuantity.Value = Convert.ToInt64(row.Cells["Quantity"].Value);
                    numericUpDownSellingPrice.Value = Convert.ToInt64(row.Cells["Selling Price"].Value);
                    numericUpDownBuyingPrice.Value = Convert.ToInt64(row.Cells["Buying Price"].Value);
                    numericUpDownLowStockWarning.Value = Convert.ToInt64(row.Cells["Low Stock Warning"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to clear all fields? Any unsaved changes will be lost.",
            "Confirm Clear",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                //enable the primary key textbox
                textBoxMedicineID.Enabled = true;

                //clear all textboxes
                textBoxMedicineID.Clear();
                textBoxMedicineName.Clear();
                numericUpDownQuantity.Value = 1;
                numericUpDownSellingPrice.Value = 1;
                numericUpDownBuyingPrice.Value = 1;
                numericUpDownLowStockWarning.Value = 1;
            }
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //if medID is empty when add is pressed show the error label
                if (textBoxMedicineID.Text.Trim() == "")
                {
                    labelErrorMedicineID.Show();
                }

                //if med name is empty when add is pressed show the error label
                if(textBoxMedicineName.Text.Trim()=="")
                { 
                    labelErrorMedicineName.Show();
                }
                //if both med ID and name are not empty
                if (textBoxMedicineID.Text.Trim() != "" && textBoxMedicineName.Text.Trim() != "")
                {
                    //check if primary key the user enterd already exsits
                    string primaryKeyCheckSql = "SELECT * FROM Medicine WHERE MedicineID = '"+textBoxMedicineID.Text+"'";

                    //creating db connecion to get connection object
                    DBConnection DBObj = new DBConnection();
                    SqlCommand comObj = new SqlCommand(primaryKeyCheckSql, DBObj.connect());

                    //reads data
                    SqlDataReader reader = comObj.ExecuteReader();
                    
                    //if db already has data to the given primary key
                    if (reader.Read())
                    {
                        //getting last primary key
                        string lastPrimaryKey = "SELECT TOP 1 * FROM Medicine ORDER BY MedicineID DESC";
                        SqlCommand comm = new SqlCommand(lastPrimaryKey, DBObj.connect());
                        SqlDataReader lastPKReader= comm.ExecuteReader();
                        lastPKReader.Read();
                       
                        MessageBox.Show("This Medicine ID already exists. Please use a different ID.\n\nLast Primary key is "+ lastPKReader["MedicineID"].ToString());
                        textBoxMedicineID.Clear();

                    }

                    //if there is no data on given primary key add the new item using that primary key
                    else
                    {
                        
                        
                        string addSql = "INSERT INTO Medicine VALUES ('" + textBoxMedicineID.Text + "', " +
                            "'" + textBoxMedicineName.Text + "'," +
                            ""+numericUpDownQuantity.Value+" ," +
                            ""+numericUpDownSellingPrice.Value+" ," +
                            ""+numericUpDownBuyingPrice.Value+"," +
                            ""+numericUpDownLowStockWarning.Value+", 1)";
                        SqlCommand addComm = new SqlCommand(addSql,DBObj.connect());
                        addComm.ExecuteNonQuery();
                        MessageBox.Show("Medicine " + textBoxMedicineName.Text + "(" + textBoxMedicineID.Text + ")" + " added successfully.", "Success");
                        loadMedicineDGV();
                    }
                    DBObj.disconnect();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void textBoxMedicineID_TextChanged(object sender, EventArgs e)
        {
            //if user types something remove the error label
            if (textBoxMedicineID.Text != "")
            {
                labelErrorMedicineID.Hide();
            }
        }

        private void textBoxMedicineName_TextChanged(object sender, EventArgs e)
        {
            //if user types something remove the error label
            if (textBoxMedicineID.Text != "")
            {
                labelErrorMedicineName.Hide();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //if med name is empty when add is pressed show the error label
                if (textBoxMedicineName.Text.Trim() == "")
                {
                    labelErrorMedicineName.Show();
                }
                else
                {
                    string sql = "UPDATE Medicine SET MedicineName = '" + textBoxMedicineName.Text + "'," +
                    " Quantity = " + numericUpDownQuantity.Value + ", " +
                    "SellingPrice = " + numericUpDownSellingPrice.Value + ", " +
                    "BuyingPrice = " + numericUpDownBuyingPrice.Value + ", " +
                    "LowStockWarning = " + numericUpDownLowStockWarning.Value + " " +
                    "WHERE MedicineID = '" + textBoxMedicineID.Text + "'";

                    DBConnection DBObj = new DBConnection();
                    SqlCommand comObj = new SqlCommand(sql, DBObj.connect());
                    comObj.ExecuteNonQuery();

                    MessageBox.Show("Medicine " + textBoxMedicineName.Text + "(" + textBoxMedicineID.Text + ")" + " updated successfully.", "Success");
                    //laoding the DGV after updating to show the restults
                    loadMedicineDGV();
                    //disconnect db
                    DBObj.disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //delete only if user selects something
                //if nothing is selected textbox will be empty
                if (textBoxMedicineID.Text.Trim() != "")
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete " + textBoxMedicineName.Text + "(" + textBoxMedicineID.Text + ")" + ". This action cannot be undone.",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                        );

                    if (result == DialogResult.Yes)
                    {
                        //there is no permenent delete in the system only can soft delete items
                        string sql = "UPDATE Medicine SET IsVisible = 0 WHERE MedicineID = '" + textBoxMedicineID.Text + "'";
                        DBConnection DBObj = new DBConnection();
                        SqlCommand com = new SqlCommand(sql, DBObj.connect());
                        com.ExecuteNonQuery();
                        MessageBox.Show(textBoxMedicineName.Text + " has been deleted successfully.", "Success");
                        loadMedicineDGV();
                    }
                }
                else
                {
                    MessageBox.Show("You need to select something to delete.", 
                        "No Selection", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning
                        );
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        
    }
}
