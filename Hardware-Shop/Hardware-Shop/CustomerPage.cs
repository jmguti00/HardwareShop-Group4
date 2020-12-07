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
        SqlConnection cs = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
        SqlDataAdapter da = new SqlDataAdapter();
        public static customer newCustomer = new customer();

        public CustomerPage()
        {
            InitializeComponent();

            try
            {
                da.SelectCommand = new SqlCommand("SELECT * FROM group4bfa202330.CustomerTable", cs);

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
            da.SelectCommand = new SqlCommand("SELECT * FROM group4bfa202330.CustomerTable", cs);

            ds.Clear();

            da.Fill(ds);

            customerTable.DataSource = ds.Tables[0];

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                da.InsertCommand = new SqlCommand("INSERT INTO group4bfa202330.CustomerTable Values(@firstName, @lastName, @Phone, @Address, @Address2, @City, @State, @ZipCode)", cs);
                da.InsertCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = txtNewFirstName.Text;
                da.InsertCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = txtNewLastName.Text;
                da.InsertCommand.Parameters.Add("@Phone", SqlDbType.VarChar).Value = txtNewPhone.Text;
                da.InsertCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = txtNewAddress1.Text;
                da.InsertCommand.Parameters.Add("@Address2", SqlDbType.VarChar).Value = txtNewAddress2.Text;
                da.InsertCommand.Parameters.Add("@City", SqlDbType.VarChar).Value = txtNewCity.Text;
                da.InsertCommand.Parameters.Add("@State", SqlDbType.VarChar).Value = txtNewState.Text;
                da.InsertCommand.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = txtNewZip.Text;

                cs.Open();

                da.InsertCommand.ExecuteNonQuery();

                cs.Close();
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

        private void btnStartOrder_Click(object sender, EventArgs e)
        {
            this.Hide();

            //assign the index of productTable datagridview
            newCustomer.id = customerTable[0, customerTable.CurrentRow.Index].Value.ToString();
            newCustomer.fName = customerTable[1, customerTable.CurrentRow.Index].Value.ToString();
            newCustomer.lName = customerTable[2, customerTable.CurrentRow.Index].Value.ToString();
            newCustomer.phoneNum = customerTable[3, customerTable.CurrentRow.Index].Value.ToString();
            newCustomer.address = customerTable[4, customerTable.CurrentRow.Index].Value.ToString();
            newCustomer.address1 = customerTable[5, customerTable.CurrentRow.Index].Value.ToString();
            newCustomer.city = customerTable[6, customerTable.CurrentRow.Index].Value.ToString();
            newCustomer.state = customerTable[7, customerTable.CurrentRow.Index].Value.ToString();
            newCustomer.zip = customerTable[8, customerTable.CurrentRow.Index].Value.ToString();

            PlaceOrder po = new PlaceOrder();
            po.Show();
        }
        
        public class customer
        {
            public string fName { get; set; }
            public string lName { get; set; }
            public string phoneNum { get; set; }
            public string address { get; set; }
            public string address1 { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string zip { get; set; }
            public string id { get; set; }
            public override string ToString()
            {
                return fName + " " + lName;
            }
        }
    }
}
