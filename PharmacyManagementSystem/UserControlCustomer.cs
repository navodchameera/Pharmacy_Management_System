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
    public partial class UserControlCustomer : UserControl
    {
        public UserControlCustomer()
        {
            InitializeComponent();
        }

        private void UserControlCustomer_Load(object sender, EventArgs e)
        {
            comboBoxGender.SelectedIndex = 0;
            buttonClearSearchBar.Hide();
            loadCustomerDGV();
        }

        public void loadCustomerDGV()
        {
            try
            {
                string sql = "SELECT CustomerID AS 'Customer ID'," +
                    " CustomerName AS 'Customer Name', DOB, " +
                    "Address, Phone, Gender " +
                    "FROM Customer " +
                    "WHERE IsVisible = 1";
                DBConnection dbObj = new DBConnection();
                SqlCommand com = new SqlCommand(sql, dbObj.connect());
                SqlDataAdapter adapter = new SqlDataAdapter(com);

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);

                dataGridViewCustomer.DataSource = tbl;
                dataGridViewCustomer.Columns["Customer ID"].Frozen = true;
                dataGridViewCustomer.Columns["Customer Name"].Frozen = true;

                dbObj.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text != "")
                {
                    buttonClearSearchBar.Show();
                    string sql = "SELECT CustomerID AS 'Customer ID'," +
                        " CustomerName AS 'Customer Name', DOB, " +
                        "Address, Phone, Gender " +
                        "FROM Customer " +
                        "WHERE IsVisible = 1 AND (CustomerID LIKE '%" + textBoxSearch.Text + "%' " +
                        "OR CustomerName LIKE '%" + textBoxSearch.Text + "%')";
                    //creating a DBConnection object to call connect method
                    DBConnection DBObj = new DBConnection();
                    SqlCommand comObj = new SqlCommand(sql, DBObj.connect());

                    SqlDataAdapter adapter = new SqlDataAdapter(comObj);

                    //making a table to get values
                    DataTable tbl = new DataTable();
                    //filling the table with data
                    adapter.Fill(tbl);
                    //giving DVG data source
                    dataGridViewCustomer.DataSource = tbl;
                    dataGridViewCustomer.Columns["Customer ID"].Frozen = true;
                    dataGridViewCustomer.Columns["Customer Name"].Frozen = true;

                    //disconnet
                    DBObj.disconnect();
                }
                else
                {
                    buttonClearSearchBar.Hide();
                    loadCustomerDGV();
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
            //after clearing stay on search
            textBoxSearch.Focus();
        }

        public bool validateInputs()
        {
            try
            {
                bool validated = false;

                if (textBoxCustomerID.Text.Trim() == "")
                {
                    labelErrorCustomerID.Show();
                }

                //validate name
                if (textBoxCustomerName.Text.Trim() == "")
                {
                    labelErrorCustomerName.Show();
                }

                //validate address
                if (textBoxAddress.Text.Trim() == "")
                {
                    labelErrorAddress.Show();
                }

                //validate phone 
                if (textBoxPhone.Text.Trim() == "")
                {
                    labelErrorPhone.Text = "*Phone can not be empty";
                    labelErrorPhone.Show();
                }
                else if (textBoxPhone.Text.Trim().Length != 10)
                {
                    labelErrorPhone.Text = "*Phone number can have only 10 digits";
                    labelErrorPhone.Show();
                }

                //validate gender
                if (comboBoxGender.SelectedIndex == 0)
                {
                    labelErrorGender.Show();
                }

                if (textBoxCustomerID.Text.Trim() != "" && textBoxCustomerName.Text.Trim() != ""
                        && textBoxAddress.Text.Trim() != "" && textBoxPhone.Text.Trim() != ""
                        && textBoxPhone.Text.Trim().Length == 10 && comboBoxGender.SelectedIndex != 0)
                {
                    validated = true;
                }

                return validated;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
                return false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //user inputs are ok....
                if (validateInputs())
                {
                    //check if primary key the user enterd already exsits
                    string primaryKeyCheckSql = "SELECT * FROM Customer WHERE CustomerID = " + textBoxCustomerID.Text.Trim() + "";

                    //creating db connecion to get connection object
                    DBConnection DBObj = new DBConnection();
                    SqlCommand primaryKeyCommand = new SqlCommand(primaryKeyCheckSql, DBObj.connect());

                    //reads data
                    SqlDataReader primaryKeyReader = primaryKeyCommand.ExecuteReader();

                    //if db already has data to the given primary key
                    if (primaryKeyReader.Read())
                    {
                        //getting last primary key
                        string lastPrimaryKey = "SELECT TOP 1 * FROM Customer ORDER BY CustomerID DESC";
                        SqlCommand comm = new SqlCommand(lastPrimaryKey, DBObj.connect());
                        SqlDataReader lastPKReader = comm.ExecuteReader();
                        lastPKReader.Read();

                        MessageBox.Show("This Customer ID already exists. Please use a different ID.\n\nLast Primary key is " + lastPKReader["CustomerID"].ToString());
                        textBoxCustomerID.Clear();
                    }

                    //if there is no data on given primary key add the new item using that primary key
                    else
                    {
                        //adding data to the db
                        string addSql = "INSERT INTO Customer VALUES " +
                            "('" + textBoxCustomerID.Text.Trim() + "', '" + textBoxCustomerName.Text.Trim() + "'," +
                            " '" + dateTimePickerDOB.Value + "', '" + textBoxAddress.Text.Trim() + "'," +
                            " '" + textBoxPhone.Text.Trim() + "', '" + comboBoxGender.SelectedItem + "', 1)";

                        SqlCommand addComm = new SqlCommand(addSql, DBObj.connect());
                        addComm.ExecuteNonQuery();
                        MessageBox.Show("Customer " + textBoxCustomerName.Text + "(" + textBoxCustomerID.Text + ") added successfully.", "Success");
                        loadCustomerDGV();
                    }
                    DBObj.disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void textBoxCustomerID_TextChanged(object sender, EventArgs e)
        {
            //if user types something hide error label
            
            labelErrorCustomerID.Hide();
        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e)
        {
            //if user types something hide error label
            
            labelErrorCustomerName.Hide();
            
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
             labelErrorPhone.Hide();
            
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            //if user types something hide error label
            
            labelErrorAddress.Hide();
            
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedIndex != 0)
            {
                labelErrorGender.Hide();
            }
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //disabling the primary key so user camn not change it
                textBoxCustomerID.Enabled = false;

                DataGridViewRow row = dataGridViewCustomer.Rows[e.RowIndex];

                textBoxCustomerID.Text = row.Cells["Customer ID"].Value.ToString();
                textBoxCustomerName.Text = row.Cells["Customer Name"].Value.ToString();
                textBoxAddress.Text = row.Cells["Address"].Value.ToString();
                textBoxPhone.Text = row.Cells["Phone"].Value.ToString();
                dateTimePickerDOB.Value = Convert.ToDateTime(row.Cells["DOB"].Value);

                //to set combobox gender
                string gender = row.Cells["Gender"].Value.ToString();
                if (gender == "Male")
                {
                    comboBoxGender.SelectedIndex = 1;
                }
                else
                {
                    comboBoxGender.SelectedIndex = 2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //if user inputs are ok...
                if (validateInputs())
                {
                    string sql = "UPDATE Customer SET " +
                        "CustomerName = '" + textBoxCustomerName.Text.Trim() + "', " +
                        "DOB = '" + dateTimePickerDOB.Value + "', " +
                        "Address = '" + textBoxAddress.Text.Trim() + "', " +
                        "Phone = '" + textBoxPhone.Text.Trim() + "', " +
                        "Gender = '" + comboBoxGender.SelectedItem + "' " +
                        "WHERE CustomerID = " + textBoxCustomerID.Text.Trim();

                    DBConnection dbObj = new DBConnection();
                    SqlCommand comObj = new SqlCommand(sql, dbObj.connect());

                    comObj.ExecuteNonQuery();
                    MessageBox.Show("Customer " + textBoxCustomerName.Text + "(" + textBoxCustomerID.Text + ") updated successfully.", "Success");
                    loadCustomerDGV();

                    dbObj.disconnect();
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
                if (textBoxCustomerID.Text.Trim() == "0")
                {
                    MessageBox.Show("You need to can not delete Walk-in Customer Record.",
                        "Can not proceed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
                else if (textBoxCustomerID.Text.Trim() != "")
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete " + textBoxCustomerName.Text + "(" + textBoxCustomerID.Text + ")" + ". This action cannot be undone.",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                        );

                    if (result == DialogResult.Yes)
                    {
                        //there is no permenent delete in the system only can soft delete items
                        string sql = "UPDATE Customer SET IsVisible = 0 WHERE CustomerID = '" + textBoxCustomerID.Text + "'";
                        DBConnection DBObj = new DBConnection();
                        SqlCommand com = new SqlCommand(sql, DBObj.connect());
                        com.ExecuteNonQuery();
                        MessageBox.Show(textBoxCustomerName.Text + " has been deleted successfully.", "Success");
                        loadCustomerDGV();
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
                textBoxCustomerID.Enabled = true;

                //clear all 
                textBoxCustomerID.Text = "";
                textBoxCustomerName.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                comboBoxGender.SelectedIndex = 0;
                dateTimePickerDOB.Value = DateTime.Now;

                //hide error labels
                labelErrorCustomerID.Hide();
                labelErrorCustomerName.Hide();
                labelErrorAddress.Hide();
                labelErrorPhone.Hide();
                labelErrorGender.Hide();
            }
        }
    }
}
