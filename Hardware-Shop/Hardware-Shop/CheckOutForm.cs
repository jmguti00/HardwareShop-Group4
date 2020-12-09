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
using System.IO;

namespace Hardware_Shop
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void btnCanel_Click(object sender, EventArgs e)
        {
            ToolsAndAccessories.cart.Clear();
            ToolsAndAccessories.vc.lstOrderSummary.Items.Clear();
            ToolsAndAccessories.vc.lblTotal.Text = "";
            ToolsAndAccessories.total = 0;


            this.Hide();
            Hardware_Shop hs = new Hardware_Shop();
            hs.Show();
        }


        public static float total = 0;
        public class item
        {
            public string itemDescription { get; set; }
            public string itemName { get; set; }
            public float itemCost { get; set; }
            public int itemStock { get; set; }

            //remove from lstBox
            public void removeItem()
            {
                total = total - itemCost;
            }

            public override string ToString()
            {
                return itemName + " " + itemCost;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                //capture current date and delivery type
                DateTime orderDate = DateTime.Now;
                SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
                con.Open();
                string payment = "";
                int theCustomerID;

                if (rdoCheck.Checked == true)
                {
                    payment = "CHECK";
                }
                if (rdoCash.Checked == true)
                {
                    payment = "CASH";
                }
                if(rdoCreditCard.Checked == true)
                {
                    payment = "CREDIT";
                    grpCardInfo.Enabled = true;
                }

                theCustomerID = int.Parse(CustomerPage.newCustomer.id.ToString());

                SqlCommand cmd = new SqlCommand("insert into group4bfa202330.OrderTable values('"+orderDate+"','"+theCustomerID+"','"+lblBalance.Text+"','"+payment+"')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Submitted!");
                

                List<item> itemList = new List<item>();
                item newItem = new item();

                foreach (int product in ToolsAndAccessories.cart)
                {
                    SqlCommand com = new SqlCommand("update group4bfa202330.Product set QtyInStock = QtyInStock - 1 where ProductID ='" + product + "'", con);
                    com.ExecuteNonQuery();
                }

                ToolsAndAccessories.cart.Clear();
                ToolsAndAccessories.vc.lstOrderSummary.Items.Clear();
                ToolsAndAccessories.vc.lblTotal.Text = "";
                ToolsAndAccessories.total = 0;

                con.Close();

                this.Close();
                CustomerPage cp = new CustomerPage();
                cp.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void rdoCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCash.Checked)
            {
                grpCardInfo.Enabled = false;
            }
        }

        private void rdoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheck.Checked)
            {
                grpCardInfo.Enabled = false;
            }
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblCustomerName.Text = CustomerPage.newCustomer.ToString();
                lblAddress.Text = CustomerPage.newCustomer.address;
                lblAddress1.Text = CustomerPage.newCustomer.address1;
                lblCity.Text = CustomerPage.newCustomer.city;
                lblState.Text = CustomerPage.newCustomer.state;
                lblZip.Text = CustomerPage.newCustomer.zip;
                lblPhoneNumber.Text = CustomerPage.newCustomer.phoneNum;

                float deliveryFee = 9.99f;
                float tax = 0.08f;
                float balance = 0;

                lblTotal.Text = ToolsAndAccessories.total.ToString("C2");
                lblDeliveryFee.Text = deliveryFee.ToString("C2");
                tax *= ToolsAndAccessories.total;
                lblTax.Text = tax.ToString("C2");
                balance = ToolsAndAccessories.total + tax + deliveryFee;
                lblBalance.Text = balance.ToString("C2");

                foreach (ToolsAndAccessories.item i in ToolsAndAccessories.vc.lstOrderSummary.Items)
                {
                    lstOrderSummary.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void rdoCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoCreditCard.Checked)
            {
                grpCardInfo.Enabled = true;
            }
            else
            {
                grpCardInfo.Enabled = false;
            }
        }

        private void btnAddMoreItems_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlaceOrder po = new PlaceOrder();
            po.Show();

        }
    }
}
