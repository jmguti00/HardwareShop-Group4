using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hardware_Shop
{
    public partial class CustomerPage : Form
    {
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
        SqlDataAdapter da = new SqlDataAdapter();
        public CustomerPage()
        {
            InitializeComponent();

            try
            {
                da.SelectCommand = new SqlCommand("SELECT * FROM group4bfa202330.CustomerTable", con);

                da.Fill(ds);

                customerTable.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM group4bfa202330.CustomerTable", con);

            ds.Clear();

            da.Fill(ds);

            customerTable.DataSource = ds.Tables[0];

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                da.InsertCommand = new SqlCommand("INSERT INTO group4bfa202330.CustomerTable Values(@firstName, @lastName, @Phone, @Address, @Address2, @City, @State, @ZipCode)", con);
                da.InsertCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = txtNewFirstName.Text;
                da.InsertCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = txtNewLastName.Text;
                da.InsertCommand.Parameters.Add("@Phone", SqlDbType.VarChar).Value = txtNewPhone.Text;
                da.InsertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtNewAddress1.Text;
                da.InsertCommand.Parameters.Add("@Address2", SqlDbType.VarChar).Value = txtNewAddress2.Text;
                da.InsertCommand.Parameters.Add("@City", SqlDbType.VarChar).Value = txtNewCity.Text;
                da.InsertCommand.Parameters.Add("@State", SqlDbType.VarChar).Value = txtNewState.Text;
                da.InsertCommand.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = txtNewZip.Text;

                con.Open();

                da.InsertCommand.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtNewFirstName.Text = "";
            txtNewLastName.Text = "";
            txtNewPhone.Text = "";
            txtNewAddress1.Text = "";
            txtNewAddress2.Text = "";
            txtNewCity.Text = "";
            txtNewState.Text = "";
            txtNewZip.Text = "";
            

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            Hardware_Shop hs = new Hardware_Shop();

            hs.Show();
        }
    }
}
