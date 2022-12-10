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
    public partial class ExpensesRecord : KryptonForm , IExpenses
    {
        ExpensesPresenter expensesPresenter;
        public ExpensesRecord()
        {
            InitializeComponent();
            expensesPresenter = new ExpensesPresenter(this);
        }

        string IExpenses.Items { get => txt_box1.Text; set => txt_box1.Text=value.ToString(); }
        int IExpenses.Quantity { get => Convert.ToInt32(txt_box2.Text); set => txt_box2.Text=value.ToString(); }
        int IExpenses.Price { get => Convert.ToInt32(txt_box3.Text); set => txt_box3.Text = value.ToString(); }
        object IExpenses.dataGridView { get =>DGVExp.DataSource; set => DGVExp.DataSource=value; }
        public DateTime AddedDate { get => addDate.Value; }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(txt_box2.Text) && !string.IsNullOrEmpty(txt_box3.Text))
            {
                bool check = expensesPresenter.ExpInsert();
                if (check)
                {
                    MessageBox.Show("Sucessfully Added");
                    Cal();
                }
            }else
                MessageBox.Show("Faild Added! Please enter all Data");
            
        }

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(txt_box2.Text) && !string.IsNullOrEmpty(txt_box3.Text))
            //{
            //    bool check = expensesPresenter.ExpUpdate();
            //    if (check)
            //    {
            //        MessageBox.Show("Sucessfully Update");
            //        Cal();
            //    }
            //}
            
            if (DGVExp.CurrentRow != null)
            {
                DGVExp.CurrentRow.Cells[0].Value = txt_box1.Text;
                DGVExp.CurrentRow.Cells[1].Value = txt_box2.Text;
                DGVExp.CurrentRow.Cells[2].Value = txt_box3.Text;
                DGVExp.CurrentRow.Cells[4].Value = addDate.Value;


            }
            else

                MessageBox.Show("Faild Update! Select the row first");

        }

        private void delbtn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(txt_box2.Text) && !string.IsNullOrEmpty(txt_box3.Text))
            {
                bool check = expensesPresenter.ExpDelete();
                if (check)
                {
                    MessageBox.Show("Sucessfully Delete");
                    Cal();

                }
            }
            else

                MessageBox.Show("Faild Delete! Select the row first");

        }

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(txt_box2.Text) && !string.IsNullOrEmpty(txt_box3.Text))
            {
                bool check = expensesPresenter.ExpReset();
                if (check)
                {
                    MessageBox.Show("Sucessfully Delete all Data");
                    Cal();

                }
            }
            else

                MessageBox.Show("Faild Reset");
            
            
        }

        private void ExpensesRecord_Load(object sender, EventArgs e)
        {
            expensesPresenter.ExpSelect();
            Cal();
        }

        public void Cal()
        {
            int sum = 0;
            for (int i = 0; i < DGVExp.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(DGVExp.Rows[i].Cells[3].Value);
            }
            txt_box5.Text = sum.ToString();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DGVExp.DataSource;
            bs.Filter = DGVExp.Columns[0].HeaderText.ToString() + " LIKE '%" + txtSearch.Text + "%'";
            DGVExp.DataSource = bs;
            
        }

        private void displayDGV(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.DGVExp.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txt_box1.Text = row.Cells[0].Value.ToString();
                txt_box2.Text = row.Cells[1].Value.ToString();
                txt_box3.Text = row.Cells[2].Value.ToString();
                addDate.Value = Convert.ToDateTime(DGVExp.Rows[e.RowIndex].Cells[4].Value.ToString());


            }
        }

        private void txt_box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
