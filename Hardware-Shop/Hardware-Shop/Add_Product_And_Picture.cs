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
    public partial class Add_Product_And_Picture : Form
    {
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group4bfa202330;Password=1938274");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        public static product Product = new product();

        public Add_Product_And_Picture()
        {
            InitializeComponent();

            //display the group4Product table on the productTable datagridview
            try
            {
                da.SelectCommand = new SqlCommand("SELECT * FROM group4bfa202330.Product", con);

                da.Fill(ds);

                productTable.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Hide the AddPicture, AddNewProduct, and UpdateInformation group boxes
            grpbxAddPicture.Visible = false;
            grpbxAddNewProduct.Visible = false;
            grpbxUpdateInformation.Visible = false;

            //disable the txtProductId textbox field
            txtProductId.Enabled = false;
        }
        
        //btnBrowse click event to browse for pictures
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Photo";
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picbxProductPicture.Image = new Bitmap(dialog.FileName);
                
            }
        }

        //btnAddPicture click event to add a picture
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            try
            {
                //open SQL connection
                con.Open();

                //create an update SQL query and assign it to string variable name sqlQuery
                string sqlQuery = "Update group4bfa202330.Product SET ProductPicture = @productPicture where ProductID = '" + txtProductId.Text +"' ";

                MemoryStream stream = new MemoryStream();

                cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@productPicture", SavePhoto());
                cmd.ExecuteNonQuery();
                
                //close sql connection
                con.Close();

                //display messagebox to show that the picture was added successfully
                MessageBox.Show("The picture was added sucessfully!!!");

                //method to reload the productTable datagridview named showProducTable
                showProductTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //call method to set field to blank
            setFieldsToBlank();

            //enable and disable the follwoing fields
            txtProductId.Enabled = false;
            txtProductName.Enabled = true;
            txtDescription.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;

            //set btnBrowse visibility to false
            btnBrowse.Visible = false;
        }

        //btnMainMenu click event to return to the main page
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //hide this page
            this.Hide();

            Hardware_Shop hs = new Hardware_Shop();
            //show Hardwar_Shop page 
            hs.Show();
        }

        //btnEnter click event to display 
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //assign the index of productTable datagridview
            Product.productID = productTable[0, productTable.CurrentRow.Index].Value.ToString();
            Product.productName = productTable[1, productTable.CurrentRow.Index].Value.ToString();
            Product.productDesc = productTable[2, productTable.CurrentRow.Index].Value.ToString();
            Product.qtyInStock = productTable[3, productTable.CurrentRow.Index].Value.ToString();
            Product.price = productTable[4, productTable.CurrentRow.Index].Value.ToString();

            //display the productTabel index infromation in the following fields
            //disable the textbox fields so that user may not typ in them
            txtProductId.Text = Product.productID;
            txtProductId.Enabled = false;
            //txtProductId.Visible = true;
            txtProductName.Text = Product.productName;
            txtProductName.Enabled = false;
            txtDescription.Text = Product.productDesc;
            txtDescription.Enabled = false;
            txtQuantity.Text = Product.qtyInStock;
            txtQuantity.Enabled = false;
            txtPrice.Text = Product.price;
            txtPrice.Enabled = false;

            //display image from the productTable
            picbxProductPicture.Image = Product.image;

            //set btnBrowse to be visible
            btnBrowse.Visible = true;
        }

        //create a public class name product
        public class product
        {
            //create objects for the product class
            public string productID { get; set; }
            public string productName { get; set; }
            public string productDesc { get; set; }
            public string qtyInStock { get; set; }
            public string price { get; set; }
            public Image image { get; set; }
        }

        //btnRefresh click event to refresh the page
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //call method to set field to blank
            setFieldsToBlank();

            //set the following groupboxes to visibility false
            grpbxAddPicture.Visible = false;
            grpbxAddNewProduct.Visible = false;
            grpbxUpdateInformation.Visible = false;

            //enable and disable the following txtbox fields
            txtProductId.Enabled = false;
            //txtProductId.Visible = true;
            txtProductName.Enabled = true;
            txtDescription.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;

            //call showProductTable method to reload the productTable datagridview
            showProductTable();
        }

        //create a method to save a picture named SavePhoto()
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            picbxProductPicture.Image.Save(ms, picbxProductPicture.Image.RawFormat);
            return ms.GetBuffer();
        }

        //btnNewBrowse click event to browse for pictures
        private void btnNewBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Photo";
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picbxProductPicture.Image = new Bitmap(dialog.FileName);
            }
        }

        //btnSave click even to save the a new product information 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //create an insert command and add the data
                da.InsertCommand = new SqlCommand("INSERT INTO group4bfa202330.Product Values(@ProductName, @ProductDesc, @QtyInStock, @Price, @ProductPicture)", con);
                da.InsertCommand.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = txtProductName.Text;
                da.InsertCommand.Parameters.Add("@ProductDesc", SqlDbType.VarChar).Value = txtDescription.Text;
                da.InsertCommand.Parameters.Add("@QtyInStock", SqlDbType.Int).Value = txtQuantity.Text;
                da.InsertCommand.Parameters.Add("@Price", SqlDbType.Float).Value = txtPrice.Text;
                da.InsertCommand.Parameters.Add("@ProductPicture", SqlDbType.Image).Value = SavePhoto();

                //open SQL connectoin
                con.Open();

                da.InsertCommand.ExecuteNonQuery();

                //close SQL connection
                con.Close();

                //display a messagebox to show the product information was saved successfully
                MessageBox.Show("The Product information was saved successfully!!!");

                //call showProducTable method to reload the productTable datagridview
                showProductTable();

                //call method to set field to blank
                setFieldsToBlank();

                //set the follwing groupboxe fields to visibilty false
                grpbxAddPicture.Visible = false;
                grpbxAddNewProduct.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //btnAddPictureMenu click event to allow grpbxAddPicture to be visible
        private void btnAddPictureMenu_Click(object sender, EventArgs e)
        {
            //set the following groupbox fields to visibilty true and false
            grpbxAddPicture.Visible = true;
            grpbxAddNewProduct.Visible = false;
            grpbxUpdateInformation.Visible = false;

            //call method to set field to blank
            setFieldsToBlank();

            //edit color properties
            grpbxAddPicture.ForeColor = System.Drawing.Color.White;
            btnEnter.ForeColor = System.Drawing.Color.Black;
            btnAddPicture.ForeColor = System.Drawing.Color.Black;

            //enable and disable the following txtbox fields
            txtProductId.Enabled = false;
            txtProductName.Enabled = true;
            txtDescription.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;


            //allow btnBrowse to be visible
            btnBrowse.ForeColor = System.Drawing.Color.Black;
            btnBrowse.Visible = false;
            
        }

        //btnAddProductMenu click event to allow grpbxAddNewProduct to be visible
        private void btnAddProductMenu_Click(object sender, EventArgs e)
        {
            //set the following groupbox fields to visibilty true and false
            grpbxAddPicture.Visible = false;
            grpbxAddNewProduct.Visible = true;
            grpbxUpdateInformation.Visible = false;

            //edit button color properties
            grpbxAddNewProduct.ForeColor = System.Drawing.Color.White;
            btnNewBrowse.ForeColor = System.Drawing.Color.Black;
            btnSave.ForeColor = System.Drawing.Color.Black;

            //call method to set field to blank
            setFieldsToBlank();

            //enable and disable the following txtbox fields
            txtProductId.Enabled = false;
            txtProductName.Enabled = true;
            txtDescription.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;
        }

        //btnAddProductMenu click event to allow grpbxUpdateInformation to be visible
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            //set the following groupbox fields to visibilty true and false
            grpbxAddPicture.Visible = false;
            grpbxAddNewProduct.Visible = false;
            grpbxUpdateInformation.Visible = true;

            //call method to set field to blank
            setFieldsToBlank();

            //enable and disable the following txtbox fields
            txtProductId.Enabled = false;
            txtProductName.Enabled = true;
            txtDescription.Enabled = true;
            txtQuantity.Enabled = true;
            txtPrice.Enabled = true;
        }

        //btnUpdateBrowse click event to browse for a picture
        private void btnUpdateBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select Photo";
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picbxProductPicture.Image = new Bitmap(dialog.FileName);
            }
        }

        //btnUpdateInfo click event to update the product information
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                //open connection
                con.Open();

                //create an update query
                string sqlQuery = "Update group4bfa202330.Product SET ProductName = @ProductName, ProductDesc = @ProductDesc, QtyInStock = @QtyInStock, Price = @Price, ProductPicture = @ProductPicture WHERE ProductID = '" + txtProductId.Text + "' ";
                
                //pass the update query
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                //add the data
                cmd.Parameters.Add("@ProductName", SqlDbType.VarChar);
                cmd.Parameters["@ProductName"].Value = txtProductName.Text;
                cmd.Parameters.Add("@ProductDesc", SqlDbType.VarChar);
                cmd.Parameters["@ProductDesc"].Value = txtDescription.Text;
                cmd.Parameters.Add("@QtyInStock", SqlDbType.Int);
                cmd.Parameters["@QtyInStock"].Value = txtQuantity.Text;
                cmd.Parameters.Add("@Price", SqlDbType.Float);
                cmd.Parameters["@Price"].Value = txtPrice.Text;
                cmd.Parameters.Add("@ProductPicture", SqlDbType.Image);
                cmd.Parameters["@ProductPicture"].Value = SavePhoto();

                cmd.ExecuteNonQuery();

                //close the connection
                con.Close();

                //display a messagebox to show the product information was updated successfully
                MessageBox.Show("The product information was updated successfully!!!");

                //call method to set field to blank
                setFieldsToBlank();

                //call showProductTable to refresh the producTable datagridview
                showProductTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //btnUpdateEnter click event to display what index row to update
        private void btnUpdateEnter_Click(object sender, EventArgs e)
        {
            try
            {
                //assign the index of productTable to productID
                Product.productID = productTable[0, productTable.CurrentRow.Index].Value.ToString();

                //assign Product.productID to txtProductId textbox
                txtProductId.Text = Product.productID;

                //open connection
                con.Open();

                //create a select query to assing what filds to update
                string sql = "Select  ProductName, ProductDesc, QtyInStock, Price, ProductPicture FROM group4bfa202330.Product WHERE ProductID = '" + txtProductId.Text + "'";

                cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                //assign the index of the table if it has data stored in it, and assign it to the following textbox fields along with the picture field
                if (reader.HasRows)
                {
                    txtProductName.Text = reader[0].ToString();
                    txtDescription.Text = reader[1].ToString();
                    txtQuantity.Text = reader[2].ToString();
                    txtPrice.Text = reader[3].ToString();
                    byte[] img = ((byte[])reader[4]);
                    
                    //if the image field is null leave it as null
                    if (img == null)
                    {
                        picbxProductPicture.Image = null;
                    }
                    //if the field is not null, assign it to picbxProductPicture
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picbxProductPicture.Image = Image.FromStream(ms);
                    }
                }

                //close connection
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //create a method to refresh the productTable datagridview
        public void showProductTable()
        {
            try
            {
                da.SelectCommand = new SqlCommand("SELECT * FROM group4bfa202330.Product", con);

                ds.Clear();

                da.Fill(ds);

                productTable.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //create a method to set certain fields to blank
        public void setFieldsToBlank()
        {
            //set the following fields to blank
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtDescription.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            picbxProductPicture.Image = null;
        }
    }
}
