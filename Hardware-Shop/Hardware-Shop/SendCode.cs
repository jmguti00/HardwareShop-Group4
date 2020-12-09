using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Hardware_Shop
{
    public partial class SendCode : Form
    {
        string randomCode;
        public static string to;

        public SendCode()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();

            if(txtEmail.Text == "julian.m.gtz@gmail.com")
            {
                from = "julian.m.gtz@gmail.com";
                pass = "sdiaenrqonqkdhkv";
                messageBody = "Your reset code is " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Password reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code send successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(txtEmail.Text == "jaykanin@gmail.com")
            {
                string from1, pass1, messageBody1;
                Random rand1 = new Random();
                randomCode = (rand1.Next(999999)).ToString();
                MailMessage message1 = new MailMessage();
                to = (txtEmail.Text).ToString();
                from1 = "jaykanin@gmail.com";
                pass1 = "udberugbgkluqaek";
                messageBody1 = "Your reset code is " + randomCode;
                message1.To.Add(to);
                message1.From = new MailAddress(from1);
                message1.Body = messageBody1;
                message1.Subject = "Password reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from1, pass1);

                try
                {
                    smtp.Send(message1);
                    MessageBox.Show("Code send successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Email is not in our files.");
            }

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerifyCode.Text).ToString())
            {
                to = txtEmail.Text;

                this.Hide();

                ResetPassword rp = new ResetPassword();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lp = new LoginPage();
            lp.Show();
        }
    }
}
