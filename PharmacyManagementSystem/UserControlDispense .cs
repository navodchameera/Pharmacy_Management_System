using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class UserControldispense : UserControl
    {
        public UserControldispense()
        {
            InitializeComponent();
        }

        private void UserControldispense_Load(object sender, EventArgs e)
        {
            buttonClearSearchBar.Hide();
        }

        private void buttonClearSearchBar_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.Focus();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                buttonClearSearchBar.Show();
            }
            else
            {
                buttonClearSearchBar.Hide();
            }
        }

        private void checkBoxRegisterdCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRegisterdCustomer.Checked)
            {
                comboBox1.Enabled = true;
            }
            else
            { 
                comboBox1.Enabled = false;
            }

        }

        
    }
}
