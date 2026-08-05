using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class UserControlEmployee : UserControl
    {
        //to store current username
        //this will help us to regonize if user changed the username or not
        private string currentUsername;
        public UserControlEmployee()
        {
            InitializeComponent();
        }

        private void UserControlEmployee_Load(object sender, EventArgs e)
        {
            comboBoxGender.SelectedIndex = 0;
            comboBoxShift.SelectedIndex = 0;
            buttonClearSearchBar.Hide();
            loadEmployeeDGV();
        }

        public void loadEmployeeDGV()
        {
            string sql = "SELECT EmployeeID AS 'Employee ID'," +
                " EmployeeName AS 'Employee Name', Username , " +
                "Address , Phone , Gender , DOB , " +
                "Shift , Salary , Role " +
                "FROM Employee " +
                "WHERE IsVisible = 1";
            DBConnection dbObj = new DBConnection();
            SqlCommand com = new SqlCommand(sql,dbObj.connect());
            SqlDataAdapter adapter = new SqlDataAdapter(com);
             
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);

            dataGridViewEmployee.DataSource = tbl;
            dataGridViewEmployee.Columns["Employee ID"].Frozen = true;
            dataGridViewEmployee.Columns["Employee Name"].Frozen = true;

            dbObj.disconnect();

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text != "")
                {
                    buttonClearSearchBar.Show();
                    string sql = "SELECT EmployeeID AS 'Employee ID'," +
                        " EmployeeName AS 'Employee Name', Username , " +
                        "Address , Phone , Gender , DOB , " +
                        "Shift , Salary , Role " +
                        "FROM Employee " +
                        "WHERE IsVisible = 1 AND (EmployeeID LIKE '%"+textBoxSearch.Text+"%' " +
                        "OR EmployeeName LIKE '%"+textBoxSearch.Text+"%'" +
                        "OR Username LIKE '%"+textBoxSearch.Text+"%')";
                    //creating a DBConnection object to call connect method
                    DBConnection DBObj = new DBConnection();
                    SqlCommand comObj = new SqlCommand(sql, DBObj.connect());

                    SqlDataAdapter adapter = new SqlDataAdapter(comObj);

                    //making a table to get values
                    DataTable tbl = new DataTable();
                    //filling the table with data
                    adapter.Fill(tbl);
                    //giving DVG data source
                    dataGridViewEmployee.DataSource = tbl;
                    dataGridViewEmployee.Columns["Employee ID"].Frozen = true;
                    dataGridViewEmployee.Columns["Employee Name"].Frozen = true;

                    //disconnet
                    DBObj.disconnect();
                }
                else
                {
                    buttonClearSearchBar.Hide();
                    loadEmployeeDGV();
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

        public bool validateInputs()
        {
            try
            {
                bool validated = false;

                if (textBoxEmployeeID.Text.Trim() == "")
                {
                    labelErrorEmployeeID.Show();
                }

                //to check if username exsists
                if (textBoxUsername.Text.Trim() == "")
                {
                    labelErrorUsername.Text = "*Username can not be empty";
                    labelErrorUsername.Show();
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

                //validate name
                if (textBoxEmployeeName.Text.Trim() == "")
                {
                    labelErrorEmployeeName.Show();
                }

                //validate address
                if (textBoxAddress.Text.Trim() == "")
                {
                    labelErrorAddress.Show();
                }

                //validate gender
                if (comboBoxGender.SelectedIndex == 0)
                {
                    labelErrorGender.Show();
                }

                //validate shift
                if (comboBoxShift.SelectedIndex == 0)
                {
                    labelErrorShift.Show();
                }

                if (textBoxEmployeeID.Text.Trim() != "" && textBoxEmployeeName.Text.Trim() != ""
                        && textBoxUsername.Text.Trim() != "" && textBoxAddress.Text.Trim() != ""
                        && textBoxPhone.Text.Trim() != "" && textBoxPhone.Text.Trim().Length == 10
                        && comboBoxGender.SelectedIndex != 0 && comboBoxShift.SelectedIndex != 0)
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
                //checks username exists and shows error
                CurrentUser userObj = new CurrentUser();
                if (!userObj.checkUsernameAvailablity(textBoxUsername.Text.Trim()))
                {
                    labelErrorUsername.Text = "*This username already exists";
                    labelErrorUsername.Show();
                }

                if (validateInputs()&& userObj.checkUsernameAvailablity(textBoxUsername.Text.Trim()))
                {
                    //check if primary key the user enterd already exsits
                    string primaryKeyCheckSql = "SELECT * FROM Employee WHERE EmployeeID = "+textBoxEmployeeID.Text.Trim()+"";

                    //creating db connecion to get connection object
                    DBConnection DBObj = new DBConnection();
                    SqlCommand primaryKeyCommand = new SqlCommand(primaryKeyCheckSql, DBObj.connect());

                    //reads data
                    SqlDataReader primaryKeyReader = primaryKeyCommand.ExecuteReader();

                    //if db already has data to the given primary key
                    if (primaryKeyReader.Read())
                    {
                        //getting last primary key
                        string lastPrimaryKey = "SELECT TOP 1 * FROM Employee ORDER BY EmployeeID DESC";
                        SqlCommand comm = new SqlCommand(lastPrimaryKey, DBObj.connect());
                        SqlDataReader lastPKReader = comm.ExecuteReader();
                        lastPKReader.Read();

                        MessageBox.Show("This Employee ID already exists. Please use a different ID.\n\nLast Primary key is " + lastPKReader["EmployeeID"].ToString());
                        textBoxEmployeeID.Clear();

                    }

                    //if there is no data on given primary key add the new item using that primary key
                    else
                    {
                        string role;
                        //setting the role based on checkbox
                        if (checkBoxAdminAccess.Checked)
                        {
                            role = "admin";
                        }
                        else
                        {
                            role = "staff";
                        }

                        //adding data to the db
                        string addSql = "INSERT INTO Employee VALUES " +
                            "('" + textBoxEmployeeID.Text.Trim() + "', '" + textBoxEmployeeName.Text.Trim() + "'," +
                            " '" + textBoxUsername.Text.Trim() + "', 'staff123', '" + textBoxAddress.Text.Trim() + "'," +
                            " '" + textBoxPhone.Text.Trim() + "', '" + comboBoxGender.SelectedItem + "', " +
                            "'" + dateTimePickerDOB.Value + "', '" + comboBoxShift.SelectedItem + "', " +
                            "" + numericUpDownSalary.Value + ", '" + role + "', 1)";
                        
                        SqlCommand addComm = new SqlCommand(addSql, DBObj.connect());
                        addComm.ExecuteNonQuery();
                        MessageBox.Show("Employee " + textBoxEmployeeName.Text + "("+textBoxEmployeeID.Text+") added successfully." +
                            "\n\nDefault password is 'staff123'. users can change it later", "Success");
                        loadEmployeeDGV();
                    }
                    DBObj.disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }
        
        private void textBoxEmployeeID_TextChanged(object sender, EventArgs e)
        {
            //if user types something hide error label
            if (textBoxEmployeeID.Text != "")
            {
                labelErrorEmployeeID.Hide();
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            //if user types something hide error label
            if (textBoxUsername.Text != "")
            {
                labelErrorUsername.Hide();
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            //if user types something hide error label
            if (textBoxPhone.Text != "")
            { 
                labelErrorPhone.Hide();
            }
        }

        private void textBoxEmployeeName_TextChanged(object sender, EventArgs e)
        {
            //if user types something hide error label
            if (textBoxEmployeeName.Text != "")
            {
                labelErrorEmployeeName.Hide();
            }
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            //if user types something hide error label
            if (textBoxAddress.Text != "")
            { 
                labelErrorAddress.Hide();
            }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if user selects one of the genders hide error label
            if (comboBoxGender.SelectedIndex != 0)
            {
                labelErrorGender.Hide();
            }
        }

        private void comboBoxShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if user selects one of the shifts hide error label
            if (comboBoxShift.SelectedIndex != 0)
            { 
                labelErrorShift.Hide();
            }
        }

        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //disabling the primary key so user camn not change it
                textBoxEmployeeID.Enabled = false;

                DataGridViewRow row = dataGridViewEmployee.Rows[e.RowIndex];

                textBoxEmployeeID.Text = row.Cells["Employee ID"].Value.ToString();
                textBoxEmployeeName.Text = row.Cells["Employee Name"].Value.ToString();
                //first saves in the varibale to detect username changes
                currentUsername = row.Cells["Username"].Value.ToString();
                //then gives it to the text box if user wants to change
                textBoxUsername.Text = currentUsername;
                
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

                //to set combo boxshift
                string shift = row.Cells["Shift"].Value.ToString();
                if (shift == "Morning")
                {
                    comboBoxShift.SelectedIndex = 1;
                }
                else if (shift == "Afternoon")
                {
                    comboBoxShift.SelectedIndex = 2;
                }
                else if (shift == "Evening")
                {
                    comboBoxShift.SelectedIndex = 3;
                }
                else
                {
                    comboBoxShift.SelectedIndex = 4;
                }

                numericUpDownSalary.Value = Convert.ToDecimal(row.Cells["Salary"].Value);

                //setting admin access checkbox
                string role = row.Cells["Role"].Value.ToString();
                if (role == "admin")
                {
                    checkBoxAdminAccess.Checked = true;
                }
                else
                {
                    checkBoxAdminAccess.Checked = false;
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
                    string role;
                    if (checkBoxAdminAccess.Checked)
                    {
                        role = "admin";
                    }
                    else
                    {
                        role = "staff";
                    }
                    string sql = "UPDATE Employee SET " +
                        "EmployeeName = '" + textBoxEmployeeName.Text.Trim() + "', " +
                        "Username = '" + textBoxUsername.Text.Trim() + "', " +
                        "Address = '" + textBoxAddress.Text.Trim() + "', " +
                        "Phone = '" + textBoxPhone.Text.Trim() + "', " +
                        "Gender = '" + comboBoxGender.SelectedItem + "', " +
                        "DOB = '" + dateTimePickerDOB.Value + "', " +
                        "Shift = '" + comboBoxShift.SelectedItem + "', " +
                        "Salary = " + numericUpDownSalary.Value + ", " +
                        "Role = '" + role + "' " +
                        "WHERE EmployeeID = " + textBoxEmployeeID.Text.Trim();

                    DBConnection dbObj = new DBConnection();
                    SqlCommand comObj = new SqlCommand(sql, dbObj.connect());

                    //if user didnt change the username
                    if (currentUsername == textBoxUsername.Text)
                    {
                        comObj.ExecuteNonQuery();
                        MessageBox.Show("Employee " + textBoxEmployeeName.Text + "(" + textBoxEmployeeID.Text + ") updated successfully.", "Success");
                        loadEmployeeDGV();
                    }
                    //user changed the username -> check if new username is available or not
                    else
                    {
                        //checks username is avaiable if it is execute the sql command
                        CurrentUser currObj = new CurrentUser();
                        if (currObj.checkUsernameAvailablity(textBoxUsername.Text.Trim()))
                        {
                            comObj.ExecuteNonQuery();
                            MessageBox.Show("Employee " + textBoxEmployeeName.Text + "(" + textBoxEmployeeID.Text + ") updated successfully.", "Success");
                            loadEmployeeDGV();
                        }
                        //if not say username alrerady exists
                        else
                        {
                            labelErrorUsername.Text = "*This username already exists";
                            labelErrorUsername.Show();
                        }
                    }
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
                if (textBoxEmployeeID.Text.Trim() != "")
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete " + textBoxEmployeeName.Text + "(" + textBoxEmployeeID.Text + ")" + ". This action cannot be undone.",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                        );

                    if (result == DialogResult.Yes)
                    {
                        //there is no permenent delete in the system only can soft delete items
                        string sql = "UPDATE Employee SET IsVisible = 0 WHERE EmployeeID = '" + textBoxEmployeeID.Text + "'";
                        DBConnection DBObj = new DBConnection();
                        SqlCommand com = new SqlCommand(sql, DBObj.connect());
                        com.ExecuteNonQuery();
                        MessageBox.Show(textBoxEmployeeName.Text + " has been deleted successfully.", "Success");
                        loadEmployeeDGV();
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
                textBoxEmployeeID.Enabled = true;

                //clear all 
                textBoxEmployeeID.Text = "";
                textBoxEmployeeName.Text = "";
                textBoxUsername.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                comboBoxGender.SelectedIndex = 0;
                comboBoxShift.SelectedIndex = 0;
                dateTimePickerDOB.Value = DateTime.Now;
                numericUpDownSalary.Value = 1000;
                checkBoxAdminAccess.Checked = false;

                //hide error labels
                labelErrorEmployeeID.Hide();
                labelErrorEmployeeName.Hide();
                labelErrorUsername.Hide();
                labelErrorAddress.Hide();
                labelErrorPhone.Hide();
                labelErrorGender.Hide();
                labelErrorShift.Hide();
            }
        }
    }
}
