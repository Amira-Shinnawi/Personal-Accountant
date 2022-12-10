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
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace personal_acountant
{
    public partial class singup : KryptonForm
    {
        public singup()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            System.Text.RegularExpressions.Regex rege = new System.Text.RegularExpressions.Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$");

            int numbercard = 16;
            int security = 3;
            int phone = 11;


            if (txtFirstName.Text == "" || txtPassword.Text == "" || txtLastName.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (!rege.IsMatch(txtPassword.Text))
            {
                MessageBox.Show("Password must be atleast 8 to 15 characters. It contains atleast one Upper case and numbers.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtPassword.Text != txtConPassword.Text)
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            else if (!expr.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("your Email invalid", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (txtPhone.Text.Length != phone)
            {
                MessageBox.Show("your number  incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtCard.Text.Length != numbercard)
            {
                MessageBox.Show("Card number must be 16 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSecurityCode.Text.Length != security)
            {
                MessageBox.Show("Enter the number on the back of the card, which contains 3 numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=KISHO;Initial Catalog=PersonalAccountant;Integrated Security=True");
                {
                    conn.Open();
                    SqlCommand sqlCmd =
                    new SqlCommand("insert into Investor values(@UserName,@InvestorPassword,@Phone,@Capital,@Email,@Gender,@InvestementType,@VisaCard,@SecurityNumber,@CardExpiaryDate)", conn);
                    //SqlCommand sqlCmd = new SqlCommand("insert into Investor values(@UserName,@InvestorPassword)" , conn);
                    sqlCmd.Parameters.AddWithValue("@UserName", txtFirstName.Text + " " + txtLastName.Text);
                    sqlCmd.Parameters.AddWithValue("@InvestorPassword", txtPassword.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Capital", int.Parse(txtProject.Text));
                    sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Gender", comboGender.SelectedItem.ToString());
                    sqlCmd.Parameters.AddWithValue("@InvestementType", txtInvestType.Text);
                    sqlCmd.Parameters.AddWithValue("@VisaCard", txtCard.Text);
                    sqlCmd.Parameters.AddWithValue("@SecurityNumber", txtSecurityCode.Text);
                    sqlCmd.Parameters.AddWithValue("@CardExpiaryDate", txtCardExpiry.Value);
                    sqlCmd.ExecuteNonQuery();
                    conn.Close();
                    login lo = new login();
                    this.Hide();
                    lo.Show();


                    Clear();
                }

            }


            void Clear()
            {
                txtFirstName.Text = txtLastName.Text = txtPassword.Text = txtConPassword.Text = txtEmail.Text = txtPhone.Text = txtInvestType.Text = txtProject.Text = txtCard.Text = txtCardExpiry.Text = txtSecurityCode.Text = "";
                comboGender.Text = "";

            }
        }

        private void txtCardExpiry_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
