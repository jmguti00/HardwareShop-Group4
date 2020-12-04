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
    public partial class LawnAndGarden : Form
    {
        public static float total = 0;
        ToolsAndAccessories.item PushLawn = new ToolsAndAccessories.item();
        ToolsAndAccessories.item RideLawn = new ToolsAndAccessories.item();
        ToolsAndAccessories.item Soil = new ToolsAndAccessories.item();
        //ViewCart vc = new ViewCart();
        SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
        string query;

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
        public LawnAndGarden()
        {
            InitializeComponent();
        }

        private void LawnAndGarden_Load(object sender, EventArgs e)
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
                    if (x == 6 || x == 7 || x == 13)
                    {
                        query = "select * from group4bfa202330.Product where ProductID = '" + x + "'";
                        con.Open();
                        SqlCommand com = new SqlCommand(query, con);
                        SqlDataReader reader = com.ExecuteReader();
                        reader.Read();

                        if (x == 6)
                        {
                            PushLawn.itemDescription = reader["ProductDesc"].ToString();
                            PushLawn.itemCost = float.Parse(reader["Price"].ToString());
                            PushLawn.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            PushLawn.itemName = reader["ProductName"].ToString();
                            PushLawn.itemId = int.Parse(reader["ProductID"].ToString());

                            lblPushLawnDesc.Text = PushLawn.itemDescription;
                            lblPricePushLawn.Text = PushLawn.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picPushLawnMow.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picPushLawnMow.Image = Image.FromStream(ms);
                            }

                        }

                        if (x == 7)
                        {
                            RideLawn.itemDescription = reader["ProductDesc"].ToString();
                            RideLawn.itemCost = float.Parse(reader["Price"].ToString());
                            RideLawn.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            RideLawn.itemName = reader["ProductName"].ToString();
                            RideLawn.itemId = int.Parse(reader["ProductID"].ToString());

                            lblRideLawnDesc.Text = RideLawn.itemDescription;
                            lblPriceRideLawn.Text = RideLawn.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picRideLawnMow.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picRideLawnMow.Image = Image.FromStream(ms);

                            }
                        }

                        if (x == 13)
                        {
                            Soil.itemDescription = reader["ProductDesc"].ToString();
                            Soil.itemCost = float.Parse(reader["Price"].ToString());
                            Soil.itemStock = int.Parse(reader["QtyInStock"].ToString());
                            Soil.itemName = reader["ProductName"].ToString();
                            Soil.itemId = int.Parse(reader["ProductID"].ToString());

                            lblSoilDesc.Text = Soil.itemDescription;
                            lblPriceSoil.Text = Soil.itemCost.ToString("C2");

                            byte[] img = ((byte[])reader["ProductPicture"]);

                            if (img == null)
                            {
                                picSoil.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picSoil.Image = Image.FromStream(ms);
                            }
                        }
                        
                    }

                    if (x > 13)
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

        private void btnAddPushLawn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 6 + "'";
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

                ToolsAndAccessories.cart.Add(PushLawn.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(PushLawn);

                //vc.lstOrderSummary.Items.Add(PushLawn);

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddRideLawn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 7 + "'";
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

                ToolsAndAccessories.cart.Add(RideLawn.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(RideLawn);

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAddSoil_Click(object sender, EventArgs e)
        {
            try
            {
                query = "select * from group4bfa202330.Product where ProductID = '" + 13 + "'";
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

                ToolsAndAccessories.cart.Add(Soil.itemId);

                //display total to label
                ToolsAndAccessories.vc.lblTotal.Text = ToolsAndAccessories.total.ToString("C2");

                ToolsAndAccessories.vc.lstOrderSummary.Items.Add(Soil);

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
