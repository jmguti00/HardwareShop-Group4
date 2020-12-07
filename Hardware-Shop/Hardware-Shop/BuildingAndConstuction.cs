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
    public partial class BuildingAndConstuction : Form
    {
        SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
        string query;
        public static float total = 0;
        ToolsAndAccessories.item Cement = new ToolsAndAccessories.item();
        ToolsAndAccessories.item DemoHammer = new ToolsAndAccessories.item();
        ToolsAndAccessories.item Light = new ToolsAndAccessories.item();
        ToolsAndAccessories.item MeasuringTape = new ToolsAndAccessories.item();
        ViewCart vc = new ViewCart();
        CheckOutForm cof = new CheckOutForm();
        
        
        public class item
        {
            public string itemDescription { get; set; }
            public string itemName { get; set; }
            public float itemCost { get; set; }
            public int itemStock { get; set; }
            public int itemId { get; set; }

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

        public BuildingAndConstuction()
        {
            InitializeComponent();

            lblOrderFor.Text = CustomerPage.newCustomer.ToString();
        }

        private void BuildingAndConstuction_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
                string query;
                bool control = true;
                
                int x = 0;
                while (control)
                {
                    x++;
                    if (x == 21 || x == 22 || x == 23 || x == 24)
                    {
                        query = "select * from group4bfa202330.Product where ProductID = '" + x + "'";
                        con.Open();
                        SqlCommand com = new SqlCommand(query, con);
                        SqlDataReader reader = com.ExecuteReader();
                        reader.Read();


                        if (x == 21)
                        {
                            Light.itemDescription = reader["ProductDesc"].ToString();
                            Light.itemCost = float.Parse(reader["Price"].ToString());
                            Light.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Light.itemName = reader["ProductName"].ToString();
                            Light.itemId = int.Parse(reader["ProductID"].ToString());

                            lblWorkLightDesc.Text = Light.itemDescription;
                            lblPriceWorkLight.Text = Light.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picWorksiteLight.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picWorksiteLight.Image = Image.FromStream(ms);
                            }

                        }

                        if (x == 22)
                        {
                            DemoHammer.itemDescription = reader["ProductDesc"].ToString();
                            DemoHammer.itemCost = float.Parse(reader["Price"].ToString());
                            DemoHammer.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            DemoHammer.itemName = reader["ProductName"].ToString();
                            DemoHammer.itemId = int.Parse(reader["ProductID"].ToString());

                            lblDemoHammerDesc.Text = DemoHammer.itemDescription;
                            lblPriceDemo.Text = DemoHammer.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picDemoHammer.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picDemoHammer.Image = Image.FromStream(ms);

                            }
                        }

                        if (x == 23)
                        {
                            Cement.itemDescription = reader["ProductDesc"].ToString();
                            Cement.itemCost = float.Parse(reader["Price"].ToString());
                            Cement.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Cement.itemName = reader["ProductName"].ToString();
                            Cement.itemId = int.Parse(reader["ProductID"].ToString());

                            lblCementDesc.Text = Cement.itemDescription;
                            lblPriceCement.Text = Cement.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picCementMixer.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picCementMixer.Image = Image.FromStream(ms);
                            }
                        }

                        if (x == 24)
                        {
                            MeasuringTape.itemDescription = reader["ProductDesc"].ToString();
                            MeasuringTape.itemCost = float.Parse(reader["Price"].ToString());
                            MeasuringTape.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            MeasuringTape.itemName = reader["ProductName"].ToString();
                            MeasuringTape.itemId = int.Parse(reader["ProductID"].ToString());

                            lblMeasuringTapeDesc.Text = MeasuringTape.itemDescription;
                            lblPriceMeasuring.Text = MeasuringTape.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picMeasuringTape.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picMeasuringTape.Image = Image.FromStream(ms);
                            }
                        }

                    }

                    if (x > 24)
                        control = false;
                    con.Close();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            PlaceOrder placeOrder = new PlaceOrder();
            placeOrder.Show();
            this.Hide();
        }

        private void btnAddCement_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 23 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                ToolsAndAccessories.total += price;

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.cart.Add(Cement.itemId);

                //display item in list
                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(Cement);
                //cof.lstOrderSummary.Items.Add(Cement);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddDemo_Click(object sender, EventArgs e)
        {
            try
            {

                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 22 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                ToolsAndAccessories.total += price;

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.cart.Add(DemoHammer.itemId);

                //display item in list
                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(DemoHammer);
                //cof.lstOrderSummary.Items.Add(DemoHammer);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddWorkLight_Click(object sender, EventArgs e)
        {
            try
            {

                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 21 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                ToolsAndAccessories.total += price;

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.cart.Add(Light.itemId);

                //display item in list
                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(Light);
                //cof.lstOrderSummary.Items.Add(Light);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddMeasuring_Click(object sender, EventArgs e)
        {
            try
            {

                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 24 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                ToolsAndAccessories.total += price;

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.cart.Add(MeasuringTape.itemId);

                //display item in list
                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(MeasuringTape);
                //cof.lstOrderSummary.Items.Add(MeasuringTape);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            ToolsAndAccessories.vc.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            CheckOutForm checkOut = new CheckOutForm();
            checkOut.Show();
        }
    }
}
