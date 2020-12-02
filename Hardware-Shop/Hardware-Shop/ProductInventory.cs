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
using System.Configuration;

namespace Hardware_Shop
{
    public partial class ProductInventory : Form
    {
        public ProductInventory()
        {
            InitializeComponent();

            try
            {
                CrystalReport1 cr = new CrystalReport1();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Hardware_Shop.Properties.Settings.HandyHardwareShopConnectionString"].ToString();

                //sql query
                string sql = "SELECT ProductID, ProductName, QtyInStock, Price FROM group4bfa202330.Product";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                adapter.Fill(ds, "Product");
                DataTable dt = ds.Tables["Product"];

                cr.SetDataSource(ds.Tables["Product"]);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();

            Hardware_Shop hs = new Hardware_Shop();
            hs.Show();
        }
    }
}
