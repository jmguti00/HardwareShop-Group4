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
    public partial class HomeRenovations : Form
    {
        item Plywood = new item();
        item Refrigerator = new item();
        item Stove = new item();
        item WaterHeater = new item();
        item Fan = new item();
        item Paints = new item();
        item AirConditioner = new item();
        item Toilet = new item();

        ViewCart vc = new ViewCart();
        public static float total = 0;
        string query;
        SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");

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

        public HomeRenovations()
        {
            InitializeComponent();
        }

        private void HomeRenovations_Load(object sender, EventArgs e)
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
                    if (x == 5 || x == 8 || x == 9 || x == 10 || x == 11 || x == 12 || x == 18 || x == 20)
                    {
                        query = "select * from group4bfa202330.Product where ProductID = '" + x + "'";
                        con.Open();
                        SqlCommand com = new SqlCommand(query, con);
                        SqlDataReader reader = com.ExecuteReader();
                        reader.Read();

                        if (x == 5)
                        {
                            Plywood.itemDescription = reader["ProductDesc"].ToString();
                            Plywood.itemCost = float.Parse(reader["Price"].ToString());
                            Plywood.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Plywood.itemName = reader["ProductName"].ToString();
                            Plywood.itemId = int.Parse(reader["ProductID"].ToString());

                            lblPlywood.Text = Plywood.itemDescription;
                            lblPriceP.Text = Plywood.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picPlywood.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picPlywood.Image = Image.FromStream(ms);
                            }

                        }
                        if (x == 8)
                        {
                            Refrigerator.itemDescription = reader["ProductDesc"].ToString();
                            Refrigerator.itemCost = float.Parse(reader["Price"].ToString());
                            Refrigerator.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Refrigerator.itemName = reader["ProductName"].ToString();
                            Refrigerator.itemId = int.Parse(reader["ProductID"].ToString());

                            lblRefrigerator.Text = Refrigerator.itemDescription;
                            lblPriceR.Text = Refrigerator.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picRefrigerator.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picRefrigerator.Image = Image.FromStream(ms);

                            }
                        }

                        if (x == 9)
                        {
                            Stove.itemDescription = reader["ProductDesc"].ToString();
                            Stove.itemCost = float.Parse(reader["Price"].ToString());
                            Stove.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Stove.itemName = reader["ProductName"].ToString();
                            Stove.itemId = int.Parse(reader["ProductID"].ToString());

                            lblStove.Text = Stove.itemDescription;
                            lblPriceS.Text = Stove.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picStove.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picStove.Image = Image.FromStream(ms);
                            }
                        }
                        if (x == 10)
                        {
                            Paints.itemDescription = reader["ProductDesc"].ToString();
                            Paints.itemCost = float.Parse(reader["Price"].ToString());
                            Paints.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Paints.itemName = reader["ProductName"].ToString();
                            Paints.itemId = int.Parse(reader["ProductID"].ToString());

                            lblPaint.Text = Paints.itemDescription;
                            lblPricePaint.Text = Paints.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picPaint.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picPaint.Image = Image.FromStream(ms);
                            }
                        }
                        if (x == 11)
                        {
                            WaterHeater.itemDescription = reader["ProductDesc"].ToString();
                            WaterHeater.itemCost = float.Parse(reader["Price"].ToString());
                            WaterHeater.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            WaterHeater.itemName = reader["ProductName"].ToString();
                            WaterHeater.itemId = int.Parse(reader["ProductID"].ToString());

                            lblWaterHeater.Text = WaterHeater.itemDescription;
                            lblPriceW.Text = WaterHeater.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picWaterHeater.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picWaterHeater.Image = Image.FromStream(ms);
                            }
                        }
                        if (x == 12)
                        {
                            Fan.itemDescription = reader["ProductDesc"].ToString();
                            Fan.itemCost = float.Parse(reader["Price"].ToString());
                            Fan.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Fan.itemName = reader["ProductName"].ToString();
                            Fan.itemId = int.Parse(reader["ProductID"].ToString());

                            lblFan.Text = Fan.itemDescription;
                            lblPriceF.Text = Fan.itemCost.ToString("C2");


                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picFan.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picFan.Image = Image.FromStream(ms);
                            }
                        }
                        if (x == 18)
                        {
                            AirConditioner.itemDescription = reader["ProductDesc"].ToString();
                            AirConditioner.itemCost = float.Parse(reader["Price"].ToString());
                            AirConditioner.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            AirConditioner.itemName = reader["ProductName"].ToString();
                            AirConditioner.itemId = int.Parse(reader["ProductID"].ToString());

                            lblAC.Text = AirConditioner.itemDescription;
                            lblPriceAC.Text = AirConditioner.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picAC.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picAC.Image = Image.FromStream(ms);
                            }
                        }

                        if (x == 20)
                        {
                            Toilet.itemDescription = reader["ProductDesc"].ToString();
                            Toilet.itemCost = float.Parse(reader["Price"].ToString());
                            Toilet.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Toilet.itemName = reader["ProductName"].ToString();
                            Toilet.itemId = int.Parse(reader["ProductID"].ToString());

                            lblToiletDesc.Text = Toilet.itemDescription;
                            lblPriceToilet.Text = Toilet.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picToilet.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picToilet.Image = Image.FromStream(ms);
                            }
                        }
                    }

                    if (x > 20)
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

        private void btnAddRefrigerator_Click(object sender, EventArgs e)
        {
            try
            {
                //amountShovels++;
                query = "select * from group4bfa202330.Product where ProductID = '" + 8 + "'";
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

                //add item to cart
                ToolsAndAccessories.cart.Add(Refrigerator.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(Refrigerator);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddStove_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 9 + "'";
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

                //add item to cart
                ToolsAndAccessories.cart.Add(Stove.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(Stove);

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
 

        private void btnAddAC_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 18 + "'";
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

                //add item to cart
                ToolsAndAccessories.cart.Add(AirConditioner.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(AirConditioner);

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddWaterHeater_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 11 + "'";
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

                //add item to cart
                ToolsAndAccessories.cart.Add(WaterHeater.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(WaterHeater);

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddFan_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 12 + "'";
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

                //add item to cart
                ToolsAndAccessories.cart.Add(Fan.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(Fan);

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddPlywood_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 5 + "'";
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

                //add item to cart
                ToolsAndAccessories.cart.Add(Plywood.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(Plywood);

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddPaint_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 10 + "'";
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

                //add item to cart
                ToolsAndAccessories.cart.Add(Paints.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(Paints);

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddToilet_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 20 + "'";
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

                //add item to cart
                ToolsAndAccessories.cart.Add(Toilet.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(Toilet);

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
    }
}
