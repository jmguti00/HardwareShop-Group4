using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_Shop
{
    public partial class ViewCart : Form
    {
        CheckOutForm cof = new CheckOutForm();
        
        public class item
        {
            float total = 0;
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

        public ViewCart()
        {
            InitializeComponent();
        }

        private void ViewCart_Load(object sender, EventArgs e)
        {
            //string item = string.Join(" ", ToolsAndAccessories.cart);
            //int x = 0;

            ////loads each item from cart into lstOrderSummary
            //foreach(ToolsAndAccessories.item i in ToolsAndAccessories.cart)
            //{
            //    x++;
            //    lstOrderSummary.Items.Add(item + " " + x);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            ToolsAndAccessories.item i = new ToolsAndAccessories.item();
            i = (ToolsAndAccessories.item)lstOrderSummary.SelectedItem;
            int index = lstOrderSummary.SelectedIndex;

            if (index >= 0)
            {
                lstOrderSummary.Items.RemoveAt(index);
                ToolsAndAccessories.total -= i.itemCost;
                lblTotal.Text = ToolsAndAccessories.total.ToString("C2");
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOrderSummary.Items.Clear();
            lblTotal.Text = "";
            ToolsAndAccessories.total = 0;
            ToolsAndAccessories.cart.Clear();
            cof.lstOrderSummary.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
