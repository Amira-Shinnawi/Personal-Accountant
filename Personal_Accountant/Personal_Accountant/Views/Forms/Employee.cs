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
    public partial class Employee : KryptonForm,IEmployee
    {
        EmployeePresenter employeePresenter;

        public Employee()
        {
            InitializeComponent();
            employeePresenter = new EmployeePresenter(this);
        }

        string IEmployee.EmpName { get => txt_box1.Text; set => txt_box1.Text = value.ToString(); }
        string IEmployee.Gender { get => cmb_gender.Text; set => cmb_gender.Text=value.ToString(); }
        double IEmployee.Salary { get =>Convert.ToDouble( txt_box3.Text); set => txt_box3.Text =value.ToString(); }
        string IEmployee.PhoneNum { get => txt_box4.Text; set => txt_box4.Text = value.ToString(); }
        object IEmployee.dataGridView { get => DGVEmp.DataSource; set => DGVEmp.DataSource = value; }


        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(cmb_gender.Text) && !string.IsNullOrEmpty(txt_box3.Text) && !string.IsNullOrEmpty(txt_box4.Text))
            {
                bool check = employeePresenter.EmpInsert();
                if (check)
                {
                    MessageBox.Show("Sucessfully Added");
                    Cal();
                }
            }
            else
                MessageBox.Show("Faild Added ! Please enter all data");
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DGVEmp.CurrentRow != null)
            {
                DGVEmp.CurrentRow.Cells[1].Value = txt_box1.Text;
                DGVEmp.CurrentRow.Cells[3].Value = txt_box3.Text;
                DGVEmp.CurrentRow.Cells[4].Value = txt_box4.Text;


            }
            else
                MessageBox.Show("Faild Updated! Select the row first");


        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(cmb_gender.Text) && !string.IsNullOrEmpty(txt_box3.Text) && !string.IsNullOrEmpty(txt_box4.Text))
            {
                bool check = employeePresenter.EmpDelete();
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
            if (!string.IsNullOrEmpty(txt_box1.Text) && !string.IsNullOrEmpty(cmb_gender.Text) && !string.IsNullOrEmpty(txt_box3.Text) && !string.IsNullOrEmpty(txt_box4.Text))
            {
                bool check = employeePresenter.EmpReset();
                if (check)
                {
                    MessageBox.Show("Sucessfully Delete all Data");
                    Cal();
                }
            }else
            
                   MessageBox.Show("Faild Reset!");
        }


        private void Employee_Load_1(object sender, EventArgs e)
        {
            employeePresenter.EmpSelect();
            Cal();

        }

        public void Cal()
        {
            int sum = 0;
            for (int i = 0; i < DGVEmp.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(DGVEmp.Rows[i].Cells[3].Value);
            }
            txt_box5.Text = sum.ToString();
        }

        private void displayDGV(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.DGVEmp.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txt_box1.Text = row.Cells[1].Value.ToString();
                cmb_gender.Text = row.Cells[2].Value.ToString();
                txt_box3.Text = row.Cells[3].Value.ToString();
                txt_box4.Text = row.Cells[4].Value.ToString();
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DGVEmp.DataSource;
            bs.Filter = DGVEmp.Columns[1].HeaderText.ToString() + " LIKE '%" + txt_Search.Text + "%'";
            DGVEmp.DataSource = bs;
            
        }

     
    }
}
