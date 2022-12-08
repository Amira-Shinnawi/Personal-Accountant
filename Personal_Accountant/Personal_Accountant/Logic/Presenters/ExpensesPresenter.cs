
using Personal_Accountant.Logic.Services;
using Personal_Accountant.Models;
using Personal_Accountant.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Accountant.Logic.Presenters
{
    class ExpensesPresenter
    {
        IExpenses expenses;
        Expenses_model ExpModel = new Expenses_model();

        public ExpensesPresenter(IExpenses view)
        {
            this.expenses = view;
        }
        private void connectbetweenModelnterface()
        {
            ExpModel.Items = expenses.Items;
            ExpModel.Quantity = expenses.Quantity;
            ExpModel.Price = expenses.Price;
            

        }
        public bool ExpInsert()
        {
            connectbetweenModelnterface();
            bool check = ExpensesServices.ExpensesInsert( expenses.Items, expenses.Quantity
                                                 , expenses.Price,expenses.AddedDate);
            ExpSelect();
            ClearFileds();
            return check;
        }
        public bool ExpUpdate()
        {
            connectbetweenModelnterface();
            bool check = ExpensesServices.ExpensesUpdate( expenses.Items, expenses.Quantity
                                                 , expenses.Price,expenses.AddedDate);
            ExpSelect();
            ClearFileds();
            return check;
        }
        public bool ExpDelete()
        {
            connectbetweenModelnterface();
            bool check = ExpensesServices.ExpensesDelete(expenses.Items);
            ExpSelect();
            ClearFileds();
            return check;
        }
        public bool ExpReset()
        {
            connectbetweenModelnterface();
            bool check = ExpensesServices.ExpensesReset();
            ExpSelect();
            ClearFileds();
            return check;
        }
        public void ClearFileds()
        {
            connectbetweenModelnterface();
            
            expenses.Items = "";
            expenses.Quantity = 0;
            expenses.Price = 0;

        }
        public void ExpSelect()
        {
            //connectbetweenModelnterface();
            expenses.dataGridView = ExpensesServices.ExpensesSelect();
        }
        
    }
}
