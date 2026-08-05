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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PharmacyManagementSystem
{
    public partial class UserControldispense : UserControl
    {
        //uses uint because quantity can not be negative 
        //and used this varibale to check if user given qunatity is avaialbe
        private int availableQunatity;

        private double sellingPrice;

        //discount is 10% for registerd customers
        private const double discountPercentage = 0.1;


        public UserControldispense()
        {
            InitializeComponent();
        }

        private void UserControldispense_Load(object sender, EventArgs e)
        {
           
            buttonClearSearchMedicineBar.Hide();
            buttonClearCustomerSearchBar.Hide();
            //loads all medicine DGV when usercontrol loads
            loadMedicineDGV();
            //loads all customers to the DGV when user control laods
            loadCustomerDGV();
            //loads next next order id to the text box
            loadNextPrimaryKey();

            //disable actions belongs to medicine. so user have to first create a order to enable them.
            buttonCalculate.Enabled = false;
            buttonAdd.Enabled = false;
            buttonRemove.Enabled = false;
            buttonFinish.Enabled = false;
            


        }

        private void buttonClearSearchBar_Click(object sender, EventArgs e)
        {
            textBoxSearchMedicine.Text = "";
            textBoxSearchMedicine.Focus();
            
        }

        public void loadMedicineDGV()
        {
            try
            {
                string sql = "SELECT MedicineID AS 'Medicine ID', MedicineName AS 'Medicine Name'," +
                    " Quantity AS 'Quantity',SellingPrice AS 'Selling Price' FROM Medicine WHERE IsVisible = 1";
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

        private void textBoxSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearchMedicine.Text != "")
                {
                    buttonClearSearchMedicineBar.Show();
                    string sql = "SELECT MedicineID AS 'Medicine ID', MedicineName AS 'Medicine Name', " +
                        "Quantity, SellingPrice AS 'Selling Price'  " +
                        "FROM Medicine " +
                        "WHERE IsVisible = 1 AND (MedicineName LIKE '%" + textBoxSearchMedicine.Text + "%' OR MedicineID LIKE '%" + textBoxSearchMedicine.Text + "%' )";
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
                    buttonClearSearchMedicineBar.Hide();
                    loadMedicineDGV();
                }
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
                    //enbaled when medicine dgv is clicked becuse if user wants to add medicine
                    numericUpDownQuantity.Enabled = true;
                    //hide error label if user presses a medicine
                    labelErrorMedicine.Hide();

                    DataGridViewRow row = dataGridViewMedicine.Rows[e.RowIndex];

                    textBoxMedicineID.Text = row.Cells["Medicine ID"].Value.ToString();
                    textBoxMedicineName.Text = row.Cells["Medicine Name"].Value.ToString();
                    availableQunatity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    sellingPrice = Convert.ToDouble(row.Cells["Selling Price"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        public void loadCustomerDGV()
        {
            try
            {
                string sql = "SELECT CustomerID AS 'Customer ID'," +
                    " CustomerName AS 'Customer Name', Phone FROM Customer " +
                    "WHERE IsVisible = 1";
                DBConnection dbObj = new DBConnection();
                SqlCommand com = new SqlCommand(sql, dbObj.connect());
                SqlDataAdapter adapter = new SqlDataAdapter(com);

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);

                dataGridViewCustomer.DataSource = tbl;


                dbObj.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        public void loadOrderdItemsDGV()
        {
            try
            {
                string sql = "SELECT Medicine.MedicineID AS ID, " +
                    "Medicine.MedicineName AS Name, " +
                    "MedicineOrder.Quantity, " +
                    "MedicineOrder.Price " +
                    "FROM Medicine JOIN MedicineOrder ON Medicine.MedicineID = MedicineOrder.MedicineID " +
                    "WHERE MedicineOrder.OrderID = '"+textBoxOrderID.Text+"'";
                DBConnection dbObj = new DBConnection();
                SqlCommand com = new SqlCommand(sql, dbObj.connect());
                SqlDataAdapter adapter = new SqlDataAdapter(com);

                DataTable tbl = new DataTable();
                adapter.Fill(tbl);

                dataGridViewOrderedItems.DataSource = tbl;


                dbObj.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //hide error label
                labelErrorCustomer.Hide();

                DataGridViewRow row = dataGridViewCustomer.Rows[e.RowIndex];

                textBoxCustomerID.Text = row.Cells["Customer ID"].Value.ToString();
                textBoxCustomerName.Text = row.Cells["Customer Name"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void textBoxSearchCustmer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearchCustomer.Text != "")
                {
                    buttonClearCustomerSearchBar.Show();
                    string sql = "SELECT CustomerID AS 'Customer ID'," +
                        " CustomerName AS 'Customer Name' " +
                        "FROM Customer " +
                        "WHERE IsVisible = 1 AND (CustomerID LIKE '%" + textBoxSearchCustomer.Text + "%' " +
                        "OR CustomerName LIKE '%" + textBoxSearchCustomer.Text + "%')";
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
                    buttonClearCustomerSearchBar.Hide();
                    loadCustomerDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCustomerID.Text.Trim() == "")
                {
                    //how error label. so user knows he has to select a customer
                    labelErrorCustomer.Show();

                }
                else
                {
                    string sql = "INSERT INTO Orders " +
                     "VALUES ('"+textBoxOrderID.Text+"', '"+textBoxCustomerID.Text+"', '"+CurrentUser.getSetCurrentUser+"', '"+DateTime.Now+"', 0, 0, 1)";
                    DBConnection DBObj = new DBConnection();
                    SqlCommand com = new SqlCommand(sql,DBObj.connect());
                    com.ExecuteNonQuery();

                    MessageBox.Show("Order " + textBoxOrderID.Text + " created successfully. You can now add medicines to this order.", "Success");

                    //disable create buttons so user can not create any other orders without finishing a order
                    buttonCreate.Enabled = false;

                    //enabel medicine related buttons so user can do Crud operations for medicine
                    buttonCalculate.Enabled = true;
                    buttonAdd.Enabled = true;
                    
                    buttonRemove.Enabled = true;
                    buttonFinish.Enabled = true;

                    //disbale the customer dgv so user can not change the customer
                    dataGridViewCustomer.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        public void loadNextPrimaryKey()
        {
            //getting last customer id
            DBConnection DBObj = new DBConnection();
            string sql = "SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID DESC";
            SqlCommand cmd = new SqlCommand(sql, DBObj.connect());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //add a one to last custoemr id (next custoemr id = last customer id + 1)
            textBoxOrderID.Text = Convert.ToString(Convert.ToInt32(reader["OrderID"]) + 1);
            DBObj.disconnect();
        }

        public double calculateUnitPrice()
        {
            //if its a walk in customer no discount will be provided
            return (sellingPrice * Convert.ToDouble(numericUpDownQuantity.Value));
        }
        
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxPrice.Text = Convert.ToString(calculateUnitPrice());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMedicineID.Text == "")
                {
                    //show error if user havent selected a medicine
                    labelErrorMedicine.Show();

                }
                else if (availableQunatity >= numericUpDownQuantity.Value)
                {
                    //when press add quantity will added to the medicine order table 
                    string sql = "INSERT INTO MedicineOrder " +
                        "VALUES ('" + textBoxOrderID.Text + "', '" + textBoxMedicineID.Text + "', " + numericUpDownQuantity.Value + ", " + calculateUnitPrice() + ")";
                    DBConnection dbObj = new DBConnection();
                    SqlCommand comObj = new SqlCommand(sql, dbObj.connect());
                    comObj.ExecuteNonQuery();



                    //reduce the medicine quantity from medicine table
                    string reduceMedicineSql = "UPDATE Medicine SET Quantity = Quantity - " + numericUpDownQuantity.Value + " " +
                        "WHERE MedicineID = '" + textBoxMedicineID.Text + "'";
                    SqlCommand updateMedQuanComObj = new SqlCommand(reduceMedicineSql, dbObj.connect());
                    updateMedQuanComObj.ExecuteNonQuery();

                    //updates total in order and diplays payments, discount and total
                    updateAndDisplayPayment();

                    //clearing medicine inputs
                    textBoxMedicineID.Text = "";
                    textBoxMedicineName.Text = "";
                    numericUpDownQuantity.Value = 1;
                    textBoxPrice.Text = "";
                }
                else
                {
                    //qunatity is more than available qunatity
                    MessageBox.Show("Can not provide "+numericUpDownQuantity.Value+". We only have "+availableQunatity, "insufficient Quantity");
                }
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        public void updateAndDisplayPayment()
        {
            try
            {
                //getting sum of all medicines of the order to calculate discount and store both discount and totalprice
                string getTotalsql = "SELECT SUM(Price) AS 'Total Price' " +
                    "FROM MedicineOrder " +
                    "WHERE OrderID = '" + textBoxOrderID.Text + "'";
                DBConnection dbObj = new DBConnection();
                SqlCommand getTotalComObj = new SqlCommand(getTotalsql, dbObj.connect());
                SqlDataReader getTotalReader = getTotalComObj.ExecuteReader();
                getTotalReader.Read();

                //stores total price to calculate discount and payment
                double totalPrice = Convert.ToDouble(getTotalReader["Total Price"]);
                double discount;

                //displays the total
                labelTotal.Text = "Total : " + totalPrice;

                //calculating discount
                if (textBoxCustomerID.Text == "0")
                {
                    //no discount for walkin customers
                    discount = 0;
                }
                else
                {
                    discount = totalPrice * discountPercentage;
                }
                //displaying the discount
                labelDiscount.Text = "Discount : " + discount;

                //calculating payment
                double payment = totalPrice - discount;
                //displaying paymenyt
                labelPayment.Text = "Payment : " + payment;


                //update in order table total price and discount
                string orderUpdateSql = "UPDATE Orders SET TotalAmount = " + payment + "," +
                    " Discount = " + discount + " WHERE OrderID = '" + textBoxOrderID.Text + "';";
                SqlCommand orderUpdateComObj = new SqlCommand(orderUpdateSql, dbObj.connect());
                orderUpdateComObj.ExecuteNonQuery();

                //loading the medicine DGV to refresh it after adding a item
                loadMedicineDGV();

                //loading the ordered items table
                loadOrderdItemsDGV();
                dbObj.disconnect();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to finish this order?",
                    "Confirm Order",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    //clear user inputs
                    textBoxOrderID.Text = "";
                    textBoxCustomerID.Text = "";
                    textBoxCustomerName.Text = "";
                    textBoxMedicineID.Text = "";
                    textBoxMedicineName.Text = "";
                    numericUpDownQuantity.Value = 1;
                    textBoxPrice.Text = "";

                    //enable create button create next order
                    buttonCreate.Enabled = true;

                    //load next primary key to the text box
                    loadNextPrimaryKey();

                    //when user finishes the order it disable the buttons again untill user creates another order
                    buttonCalculate.Enabled = false;
                    buttonAdd.Enabled = false;
                    buttonRemove.Enabled = false;
                    buttonFinish.Enabled = false;

                    //clearing labels after finishing
                    labelTotal.Text = "Total : ";
                    labelDiscount.Text = "Discount : ";
                    labelPayment.Text = "Payment : ";

                    //clear order items table
                    dataGridViewOrderedItems.DataSource = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMedicineID.Text.Trim() != "")
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to remove " + textBoxMedicineName.Text,
                        "Confirm Remove",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                        );

                    if (result == DialogResult.Yes)
                    {
                        //add the quntity back to medicine table
                        string addBackSql = "UPDATE Medicine SET Quantity = Quantity + " + numericUpDownQuantity.Value +
                            " WHERE MedicineID = " + textBoxMedicineID.Text;
                        DBConnection DBObj = new DBConnection();
                        SqlCommand addBackComObj = new SqlCommand(addBackSql, DBObj.connect());
                        addBackComObj.ExecuteNonQuery();

                        //delete the item
                        string sql = "DELETE FROM MedicineOrder " +
                            "WHERE OrderID = '" + textBoxOrderID.Text + "' AND MedicineID = '" + textBoxMedicineID.Text + "'";
                        SqlCommand com = new SqlCommand(sql, DBObj.connect());
                        com.ExecuteNonQuery();
                        MessageBox.Show(textBoxMedicineName.Text + " has been removed successfully.", "Success");
                        loadMedicineDGV();
                        loadOrderdItemsDGV();
                        updateAndDisplayPayment();
                        DBObj.disconnect();

                        //clearing medicine inputs
                        textBoxMedicineID.Text = "";
                        textBoxMedicineName.Text = "";
                        numericUpDownQuantity.Value = 1;
                        textBoxPrice.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("You need to select something to remove.",
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

        private void dataGridViewOrderedItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //disabled so user wont acidentaly change qunatity
                numericUpDownQuantity.Enabled = false;

                DataGridViewRow row = dataGridViewOrderedItems.Rows[e.RowIndex];

                textBoxMedicineID.Text = row.Cells["ID"].Value.ToString();
                textBoxMedicineName.Text = row.Cells["Name"].Value.ToString();
                numericUpDownQuantity.Value = Convert.ToDecimal(row.Cells["Quantity"].Value);
                textBoxPrice.Text = row.Cells["Price"].Value.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }
    }
}
