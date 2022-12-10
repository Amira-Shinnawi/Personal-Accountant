using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using ComponentFactory.Krypton.Toolkit;

namespace personal_acountant
{
    public partial class Resetpassword : KryptonForm
    {
        string email = sendcode.to;
        public Resetpassword()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rege = new System.Text.RegularExpressions.Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$");
            if (!rege.IsMatch(txtresetpass.Text))
            {
                MessageBox.Show("Password must be atleast 8 to 15 characters. It contains atleast one Upper case and numbers.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtresetpass.Text == txtresetpassver.Text)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=KISHO;Initial Catalog=PersonalAccountant;Integrated Security=True");
                SqlCommand sqlCmd = new SqlCommand("UPDATE[dbo].[Investor] SET [InvestorPassword] = '" + txtresetpassver.Text + "'WHERE Email='" + email + "' ", conn);
                conn.Open();
                sqlCmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Reset successfully");
            }
            else
            {
                MessageBox.Show("the new password do not match so enter same password");
            }
        }
    }
}
