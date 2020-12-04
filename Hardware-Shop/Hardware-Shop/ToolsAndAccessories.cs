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
    public partial class ToolsAndAccessories : Form
    {
        SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
        string query;
        public static float total = 0;
        item Shovel = new item();
        item Gloves = new item();
        item ScrewDriver = new item();
        item Hammer = new item();
        item Ladders = new item();
        item Drills = new item();
        item Axes = new item();
        public static ViewCart vc = new ViewCart();

        public static List<int> cart = new List<int>();

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

        public ToolsAndAccessories()
        {
            InitializeComponent();
        }

        

        private void ToolsAndAccessories_Load(object sender, EventArgs e)
        {
            try
            {
                
                //con.Close();
                //SqlCommand com = new SqlCommand(query, con);
                //SqlDataReader reader = com.ExecuteReader();
                //reader.Read();
                //lblDescription.Text = reader["ProductDesc"].ToString();

                

                bool control = true;

                int x = 0;
                while(control)
                {
                    x++;
                    if (x == 1 || x == 2 || x == 3 || x == 4 || x == 14 || x == 15 || x == 17)
                    {
                        query = "select * from group4bfa202330.Product where ProductID = '" + x + "'";
                        con.Open();
                        SqlCommand com = new SqlCommand(query, con);
                        SqlDataReader reader = com.ExecuteReader();
                        reader.Read();


                        if (x == 1)
                        {
                            
                            ScrewDriver.itemDescription = reader["ProductDesc"].ToString();
                            ScrewDriver.itemCost = float.Parse(reader["Price"].ToString());
                            ScrewDriver.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            ScrewDriver.itemName = reader["ProductName"].ToString();
                            ScrewDriver.itemId = int.Parse(reader["ProductID"].ToString());

                            lblScrewDesc.Text = ScrewDriver.itemDescription;
                            lblPrice.Text = ScrewDriver.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picScrewDrivers.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picScrewDrivers.Image = Image.FromStream(ms);
                            }

                        }
                        if (x == 2)
                        {
                            
                            Hammer.itemDescription = reader["ProductDesc"].ToString();
                            Hammer.itemCost = float.Parse(reader["Price"].ToString());
                            Hammer.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Hammer.itemName = reader["ProductName"].ToString();
                            Hammer.itemId = int.Parse(reader["ProductID"].ToString());

                            lblHammers.Text = Hammer.itemDescription;
                            lblPriceH.Text = Hammer.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picHammer.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picHammer.Image = Image.FromStream(ms);

                            }
                        }

                        if (x == 3)
                        {
                            
                            Ladders.itemDescription = reader["ProductDesc"].ToString();
                            Ladders.itemCost = float.Parse(reader["Price"].ToString());
                            Ladders.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Ladders.itemName = reader["ProductName"].ToString();
                            Ladders.itemId = int.Parse(reader["ProductID"].ToString());

                            lblLadders.Text = Ladders.itemDescription;
                            lblPriceL.Text = Ladders.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picLadders.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picLadders.Image = Image.FromStream(ms);
                            }
                        }
                        if (x == 4)
                        {
                            
                            Drills.itemDescription = reader["ProductDesc"].ToString();
                            Drills.itemCost = float.Parse(reader["Price"].ToString());
                            Drills.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Drills.itemName = reader["ProductName"].ToString();
                            Drills.itemId = int.Parse(reader["ProductID"].ToString());

                            lblDrills.Text = Drills.itemDescription;
                            lblPriceD.Text = Drills.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picDrills.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picDrills.Image = Image.FromStream(ms);
                            }
                        }
                        if (x == 14)
                        {
                            
                            Axes.itemDescription = reader["ProductDesc"].ToString();
                            Axes.itemCost = float.Parse(reader["Price"].ToString());
                            Axes.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Axes.itemName = reader["ProductName"].ToString();
                            Axes.itemId = int.Parse(reader["ProductID"].ToString());

                            lblAxes.Text = Axes.itemDescription;
                            lblPriceA.Text = Axes.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picAxes.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picAxes.Image = Image.FromStream(ms);
                            }
                        }

                        if (x == 15)
                        {
                            Shovel.itemDescription = reader["ProductDesc"].ToString();
                            Shovel.itemCost = float.Parse(reader["Price"].ToString());
                            Shovel.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Shovel.itemName = reader["ProductName"].ToString();
                            Shovel.itemId = int.Parse(reader["ProductId"].ToString());

                            lblShovels.Text = Shovel.itemDescription;
                            lblPriceS.Text = Shovel.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picShovel.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picShovel.Image = Image.FromStream(ms);
                            }
                        }




                        if (x == 17)
                        {
                            
                            Gloves.itemDescription = reader["ProductDesc"].ToString();
                            Gloves.itemCost = float.Parse(reader["Price"].ToString());
                            Gloves.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Gloves.itemName = reader["ProductName"].ToString();
                            Gloves.itemId = int.Parse(reader["ProductID"].ToString());

                            lblGloves.Text = Gloves.itemDescription;
                            lblPriceG.Text = Gloves.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picGloves.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picGloves.Image = Image.FromStream(ms);
                            }
                        }
                    }

                    if (x > 17)
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

        private void btnAddShovels_Click(object sender, EventArgs e)
        {

            
        }

        //Add shovels to order
        private void btnAddShovels_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 15 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                total += price;

                //add item to cart
                cart.Add(Shovel.itemId);

                //display total to label
                vc.lblTotal.Text = total.ToString("C2");

                //display item in list
                vc.lstOrderSummary.Items.Add(Shovel);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstCart.SelectedIndex;
            //amountShovels--;
            item test = new item();
            test = (item)lstCart.SelectedItem;

            if(index != -1)
            {
                lstCart.Items.RemoveAt(index);
                test.removeItem();
                lblTotal.Text = total.ToString("C2");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCart.Items.Clear();
            lblTotal.Text = "";
            total = 0;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOut = new CheckOutForm();
            checkOut.Show();
            this.Hide();

        }

        private void btnAddScrewDrivers_Click(object sender, EventArgs e)
        {
            try
            {
                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 1 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                total += price;

                //add item to cart
                cart.Add(ScrewDriver.itemId);

                //display total to label
                vc.lblTotal.Text = total.ToString("C2");

                //display item in list box
                vc.lstOrderSummary.Items.Add(ScrewDriver);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddHammers_Click(object sender, EventArgs e)
        {
            try
            {
                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 2 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                total += price;

                
                //display total to label
                vc.lblTotal.Text = total.ToString("C2");

                cart.Add(Hammer.itemId);
                vc.lstOrderSummary.Items.Add(Hammer);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddDrills_Click(object sender, EventArgs e)
        {
            try
            {
                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 4 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                total += price;

                //display total to label
                vc.lblTotal.Text = total.ToString("C2");

                cart.Add(Drills.itemId);
                vc.lstOrderSummary.Items.Add(Drills);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddGloves_Click(object sender, EventArgs e)
        {
            try
            {
                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 17 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                total += price;

                //display total to label
                vc.lblTotal.Text = total.ToString("C2");

                cart.Add(Gloves.itemId);
                vc.lstOrderSummary.Items.Add(Gloves);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddLadders_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 3 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                total += price;

                //display total to label
                vc.lblTotal.Text = total.ToString("C2");

                cart.Add(Ladders.itemId);
                vc.lstOrderSummary.Items.Add(Ladders);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddAxes_Click(object sender, EventArgs e)
        {
            try
            {
                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 14 + "'";
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();

                //declare variables
                float price = 0;

                //capture price from database and store it in variable
                price = float.Parse(reader["Price"].ToString());

                //calculate total
                total += price;

                //display total to label
                vc.lblTotal.Text = total.ToString("C2");

                cart.Add(Axes.itemId);
                vc.lstOrderSummary.Items.Add(Axes);
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            vc.Show();           
        }
    }
}
