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
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;



namespace personal_acountant
{
    public partial class login : KryptonForm
    {
        public login()
        {
            InitializeComponent();
        }




        SqlConnection conn = new SqlConnection(@"Data Source=KISHO;Initial Catalog=PersonalAccountant;Integrated Security=True");

        private void btn_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = textemail.Text;
            user_password = textpassword.Text;
            try
            {
                string querry = "Select * from Investor WHERE Email = '" + textemail.Text + "' AND InvestorPassword ='" + textpassword.Text + " '";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = textemail.Text; ;
                    user_password = textpassword.Text;

                    Main ma = new Main();
                    this.Hide();
                    ma.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textemail.Clear();
                    textpassword.Clear();
                    textemail.Focus();
                }
            }
            catch
            {
                MessageBox.Show("your password or email incorrect.");
            }
            finally
            {
                conn.Close();
            }
        }



        private void creataccountt_LinkClicked(object sender, EventArgs e)
        {
            singup si = new singup();
            this.Hide();
            si.Show();
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            sendcode sc = new sendcode();
            this.Hide();
            sc.Show();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {
        }
    }
}












