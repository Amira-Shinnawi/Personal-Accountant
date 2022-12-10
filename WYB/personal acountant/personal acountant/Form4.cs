using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace personal_acountant
{
    public partial class sendcode : KryptonForm
    {
        string randomcode;
        public static string to;

        public sendcode()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtvercode_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (txtemail.Text == "") { MessageBox.Show("Please Enter your Email"); }
            string from, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtemail.Text).ToString();
            from = "badawykareem74@gmail.com";
            pass = "badawykareem666666";
            messagebody = $"your reset code is {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "password reset code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code successfully send");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {

            if (randomcode == (txtvercode.Text).ToString())
            {
                to = txtemail.Text;
                Resetpassword rp = new Resetpassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("wrong password");
            }
        }
    }
}
