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
    public partial class UserControlRestock : UserControl
    {

        private double buyingPrice;

        public UserControlRestock()
        {
            InitializeComponent();
        }

        private void UserControlRestock_Load(object sender, EventArgs e)
        {
            buttonClearSearchMedicineBar.Hide();
            //loads all medicine to the dgv when usercontrol loads
            loadMedicineDGV();
            //loads all restock batches to the dgv when usercontrol loads
            loadRestockDGV();
            //loads next batch id to the text box
            loadNextPrimaryKey();
        }

        public void loadMedicineDGV()
        {
            try
            {
                string sql = "SELECT MedicineID AS 'Medicine ID', MedicineName AS 'Medicine Name', " +
                    "Quantity AS 'Quantity', BuyingPrice AS 'Buying Price' FROM Medicine WHERE IsVisible = 1";

                DBConnection DBObj = new DBConnection();
                using (SqlCommand comObj = new SqlCommand(sql, DBObj.connect()))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(comObj);
                    DataTable tbl = new DataTable();
                    adapter.Fill(tbl);
                    dataGridViewMedicine.DataSource = tbl;
                }
                DBObj.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }



        private void buttonClearSearchMedicineBar_Click(object sender, EventArgs e)
        {
            textBoxSearchMedicine.Text = "";
            textBoxSearchMedicine.Focus();
        }

        private void textBoxSearchMedicine_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearchMedicine.Text != "")
                {
                    buttonClearSearchMedicineBar.Show();
                    string sql = "SELECT MedicineID AS 'Medicine ID', MedicineName AS 'Medicine Name', " +
                        "Quantity AS 'Quantity' FROM Medicine " +
                        "WHERE IsVisible = 1 AND (MedicineName LIKE @search OR MedicineID LIKE @search)";

                    //creating a DBConnection object to call connect method
                    DBConnection DBObj = new DBConnection();
                    using (SqlCommand comObj = new SqlCommand(sql, DBObj.connect()))
                    {
                        //using parameter instead of concatenating text directly into sql
                        comObj.Parameters.AddWithValue("@search", "%" + textBoxSearchMedicine.Text + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(comObj);

                        //making a table to get values
                        DataTable tbl = new DataTable();
                        //filling the table with data
                        adapter.Fill(tbl);
                        //giving dgv data source
                        dataGridViewMedicine.DataSource = tbl;
                    }
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
                if (e.RowIndex >= 0)
                {
                    labelErrorMedicine.Hide();

                    DataGridViewRow row = dataGridViewMedicine.Rows[e.RowIndex];

                    textBoxMedicineID.Text = row.Cells["Medicine ID"].Value.ToString();
                    textBoxMedicineName.Text = row.Cells["Medicine Name"].Value.ToString();
                    //store buying price so total can be calculated when qunatity changes
                    buyingPrice = Convert.ToDouble(row.Cells["Buying Price"].Value);

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        public void loadRestockDGV()
        {
            try
            {
                string sql = "SELECT Restock.BatchID AS 'Batch ID', Medicine.MedicineID AS 'Medicine ID', " +
                    "Medicine.MedicineName AS 'Medicine Name', Restock.Quantity AS 'Quantity', " +
                    "Restock.RestockDate AS 'Restock Date', Restock.ManufacturedDate AS 'Manufactured Date', " +
                    "Restock.ExpiryDate AS 'Expiry Date', Restock.TotalPrice AS 'Total Price' " +
                    "FROM Restock JOIN Medicine ON Restock.MedicineID = Medicine.MedicineID " +
                    "ORDER BY Restock.BatchID DESC";

                DBConnection DBObj = new DBConnection();
                using (SqlCommand comObj = new SqlCommand(sql, DBObj.connect()))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(comObj);

                    //making a table to get values
                    DataTable tbl = new DataTable();
                    //filling the table with data
                    adapter.Fill(tbl);
                    //giving dgv data source
                    dataGridViewRestock.DataSource = tbl;
                }
                DBObj.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void textBoxSearchBatch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearchBatch.Text != "")
                {
                    buttonClearBatchSearchBar.Show();
                    string sql = "SELECT Restock.BatchID AS 'Batch ID', Medicine.MedicineID AS 'Medicine ID', " +
                        "Medicine.MedicineName AS 'Medicine Name', Restock.Quantity AS 'Quantity', " +
                        "Restock.RestockDate AS 'Restock Date', Restock.ManufacturedDate AS 'Manufactured Date', " +
                        "Restock.ExpiryDate AS 'Expiry Date', Restock.TotalPrice AS 'Total Price' " +
                        "FROM Restock JOIN Medicine ON Restock.MedicineID = Medicine.MedicineID " +
                        "WHERE Restock.BatchID LIKE @search OR Medicine.MedicineName LIKE @search " +
                        "ORDER BY Restock.BatchID DESC";

                    //creating a DBConnection object to call connect method
                    DBConnection DBObj = new DBConnection();
                    using (SqlCommand comObj = new SqlCommand(sql, DBObj.connect()))
                    {
                        comObj.Parameters.AddWithValue("@search", "%" + textBoxSearchBatch.Text + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(comObj);

                        //making a table to get values
                        DataTable tbl = new DataTable();
                        //filling the table with data
                        adapter.Fill(tbl);
                        //giving dgv data source
                        dataGridViewRestock.DataSource = tbl;
                    }
                    //disconnet
                    DBObj.disconnect();
                }
                else
                {
                    buttonClearBatchSearchBar.Hide();
                    loadRestockDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonClearBatchSearchBar_Click(object sender, EventArgs e)
        {
            textBoxSearchBatch.Text = "";
            textBoxSearchBatch.Focus();
        }

        public void loadNextPrimaryKey()
        {
            try
            {
                //getting last batch id
                DBConnection DBObj = new DBConnection();
                string sql = "SELECT TOP 1 BatchID FROM Restock ORDER BY BatchID DESC";
                using (SqlCommand cmd = new SqlCommand(sql, DBObj.connect()))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //add one to last batch id (next batch id = last batch id + 1)
                    if (reader.Read())
                        textBoxBatchID.Text = Convert.ToString(Convert.ToInt32(reader["BatchID"]) + 1);
                    else
                        //no restock rows yet, so start from 1
                        textBoxBatchID.Text = "1";
                }
                DBObj.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMedicineID.Text.Trim() == "")
                {
                    //show error if user havent selected a medicine
                    labelErrorMedicine.Show();
                    return;
                }

                //expiry date must be after manufactured date, otherwise its invalid
                if (dateTimePickerExpiryDate.Value <= dateTimePickerManufacturedDate.Value)
                {
                    MessageBox.Show("Expiry date must be after manufactured date.", "Invalid Dates");
                    return;
                }

                DBConnection DBObj = new DBConnection();

                //insert new restock batch into restock table
                string insertSql = "INSERT INTO Restock " +
                    "(BatchID, MedicineID, Quantity, RestockDate, ManufacturedDate, ExpiryDate, TotalPrice) " +
                    "VALUES (@BatchID, @MedicineID, @Quantity, @RestockDate, @ManufacturedDate, @ExpiryDate, @TotalPrice)";

                using (SqlCommand comObj = new SqlCommand(insertSql, DBObj.connect()))
                {
                    comObj.Parameters.AddWithValue("@BatchID", textBoxBatchID.Text);
                    comObj.Parameters.AddWithValue("@MedicineID", textBoxMedicineID.Text);
                    comObj.Parameters.AddWithValue("@Quantity", numericUpDownQuantity.Value);
                    comObj.Parameters.AddWithValue("@RestockDate", DateTime.Now);
                    comObj.Parameters.AddWithValue("@ManufacturedDate", dateTimePickerManufacturedDate.Value.Date);
                    comObj.Parameters.AddWithValue("@ExpiryDate", dateTimePickerExpiryDate.Value.Date);
                    comObj.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(calculateTotalPrice())); // TODO: wire up real price
                    comObj.ExecuteNonQuery();
                }


                //add the restocked qunatity to the medicine table
                string updateSql = "UPDATE Medicine SET Quantity = Quantity + @Quantity WHERE MedicineID = @MedicineID";
                using (SqlCommand updateComObj = new SqlCommand(updateSql, DBObj.connect()))
                {
                    updateComObj.Parameters.AddWithValue("@Quantity", numericUpDownQuantity.Value);
                    updateComObj.Parameters.AddWithValue("@MedicineID", textBoxMedicineID.Text);
                    updateComObj.ExecuteNonQuery();
                }

                DBObj.disconnect();

                MessageBox.Show(textBoxMedicineName.Text + " restocked successfully.", "Success");

                //clearing inputs and refreshing dgvs after adding a batch
                buttonClear_Click(sender, e);
                loadRestockDGV();
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
                if (dataGridViewRestock.SelectedRows.Count == 0)
                {
                    //user needs to select a batch first
                    MessageBox.Show("Select a batch to delete.", "No Selection");
                    return;
                }

                DataGridViewRow row = dataGridViewRestock.SelectedRows[0];
                string batchId = row.Cells["Batch ID"].Value.ToString();
                string medId = row.Cells["Medicine ID"].Value.ToString();
                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete batch " + batchId + "?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DBConnection DBObj = new DBConnection();

                    //remove the qunatity this batch added, since batch no longer exists
                    string updateSql = "UPDATE Medicine SET Quantity = Quantity - @Quantity WHERE MedicineID = @MedicineID";
                    using (SqlCommand updateComObj = new SqlCommand(updateSql, DBObj.connect()))
                    {
                        updateComObj.Parameters.AddWithValue("@Quantity", qty);
                        updateComObj.Parameters.AddWithValue("@MedicineID", medId);
                        updateComObj.ExecuteNonQuery();
                    }

                    //delete the batch record
                    string deleteSql = "DELETE FROM Restock WHERE BatchID = @BatchID";
                    using (SqlCommand deleteComObj = new SqlCommand(deleteSql, DBObj.connect()))
                    {
                        deleteComObj.Parameters.AddWithValue("@BatchID", batchId);
                        deleteComObj.ExecuteNonQuery();
                    }

                    DBObj.disconnect();

                    MessageBox.Show("Batch deleted successfully.", "Success");
                    //refresh both dgvs so quantity and batch list stay in sync
                    loadRestockDGV();
                    loadMedicineDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went worng. Try again \n\n" + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clearing medicine inputs
            textBoxMedicineID.Text = "";
            textBoxMedicineName.Text = "";
            numericUpDownQuantity.Value = 1;
            dateTimePickerManufacturedDate.Value = DateTime.Now;
            dateTimePickerExpiryDate.Value = DateTime.Now;
            labelErrorMedicine.Hide();

            //load next batch id to the text box
            loadNextPrimaryKey();
        }

        public double calculateTotalPrice()
        {
            //total price for this batch = buying price * qunatity restocked
            return (buyingPrice * Convert.ToDouble(numericUpDownQuantity.Value));
        }
    }

}
