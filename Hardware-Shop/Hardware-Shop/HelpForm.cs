using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Hardware_Shop
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            try
            {
                InitializeComponent();

                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Help Document.txt");
                string whatToRemove = "\\Debug";
                string result = path.Replace(whatToRemove, "");
                TextReader reader = new StreamReader(result);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hardware_Shop hs = new Hardware_Shop();
            hs.Show();
        }
    }
}
