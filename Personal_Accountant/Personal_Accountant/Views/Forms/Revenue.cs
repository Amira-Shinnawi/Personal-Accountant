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
using Personal_Accountant.Logic.Presenters;
using Personal_Accountant.Views.Interface;

namespace Personal_Accountant.Views.Forms
{
    public partial class Revenue : KryptonForm, IRevenue
    {
        RevenuePresenter revenuePresenter;
        public Revenue()
        {
            InitializeComponent();
            revenuePresenter = new RevenuePresenter(this);
        }

        string IRevenue.Items { get => txt_box1.Text; set => txt_box1.Text = value.ToString(); }
        int IRevenue.Quantity { get => Convert.ToInt32(txt_box2.Text); set => txt_box2.Text = value.ToString(); }
        int IRevenue.Price { get => Convert.ToInt32(txt_box3.Text); set => txt_box3.Text = value.ToString(); }
        object IRevenue.dataGridView { get => DGVRev.DataSource; set => DGVRev.DataSource = value; }
        public DateTime AddedDate { get => addDate.Value; }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(txt_box2.Text) && !string.IsNullOrEmpty(txt_box3.Text))
            {
                bool check = revenuePresenter.RevInsert();
                if (check)
                {
                    MessageBox.Show("Sucessfully Added");
                    Cal();

                }
            }
            else

                MessageBox.Show("Faild Added! Please enter all data");
            
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVRev.CurrentRow != null)
            {
                DGVRev.CurrentRow.Cells[0].Value = txt_box1.Text;
                DGVRev.CurrentRow.Cells[1].Value = txt_box2.Text;
                DGVRev.CurrentRow.Cells[2].Value = txt_box3.Text;
                DGVRev.CurrentRow.Cells[4].Value = addDate.Value;

            }
            else

                MessageBox.Show("Faild Update! Select the row first");
            
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(txt_box2.Text) && !string.IsNullOrEmpty(txt_box3.Text))
            {
                bool check = revenuePresenter.RevDelete();
                if (check)
                {
                    MessageBox.Show("Sucessfully Delete");
                    Cal();
                }
            }
            else

                MessageBox.Show("Faild Delete! Select the row first");
            
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(txt_box2.Text) && !string.IsNullOrEmpty(txt_box3.Text))
            {
                bool check = revenuePresenter.RevReset();
                if (check)
                {
                    MessageBox.Show("Sucessfully Delete all Data");
                    Cal();
                }
            }
            else

                MessageBox.Show("Faild Reset");
            
        }
        private void Revenue_Load(object sender, EventArgs e)
        {
            revenuePresenter.RevSelect();
            Cal();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DGVRev.DataSource;
            bs.Filter = DGVRev.Columns[0].HeaderText.ToString() + " LIKE '%" + txt_Search.Text + "%'";
            DGVRev.DataSource = bs;
        }
        public void Cal()
        {
            int sum = 0;
            for (int i = 0; i < DGVRev.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(DGVRev.Rows[i].Cells[3].Value);
            }
            txt_box5.Text = sum.ToString();
        }

        private void displayRev(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.DGVRev.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txt_box1.Text = row.Cells[0].Value.ToString();
                txt_box2.Text = row.Cells[1].Value.ToString();
                txt_box3.Text = row.Cells[2].Value.ToString();
                addDate.Value = Convert.ToDateTime(DGVRev.Rows[e.RowIndex].Cells[4].Value.ToString());


            }
        }

      

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGVRev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_box3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_box2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txt_box5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Search_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
