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
    class RevenuePresenter
    {
        IRevenue revenue;
        Revenue_model RevModel = new Revenue_model();

        public RevenuePresenter(IRevenue view)
        {
            this.revenue = view;
        }
        private void connectbetweenModelnterface()
        {
            RevModel.Items = revenue.Items;
            RevModel.Quantity = revenue.Quantity;
            RevModel.Price = revenue.Price;

        }
        public bool RevInsert()
        {
            connectbetweenModelnterface();
            bool check = RevenueServices.RevenueInsert(revenue.Items, revenue.Quantity
                                                 , revenue.Price, revenue.AddedDate);
            RevSelect();
            ClearFileds();
            return check;
        }
        public bool RevUpdate()
        {
            connectbetweenModelnterface();
            bool check = RevenueServices.RevenueUpdate(revenue.Items, revenue.Quantity
                                                 , revenue.Price, revenue.AddedDate);
            RevSelect();
            return check;
        }
        public bool RevDelete()
        {
            connectbetweenModelnterface();
            bool check = RevenueServices.RevenueDelete(revenue.Items);
            RevSelect();
            return check;
        }
        public bool RevReset()
        {
            connectbetweenModelnterface();
            bool check = RevenueServices.RevenueReset();
            RevSelect();
            return check;
        }
        public void ClearFileds()
        {
            connectbetweenModelnterface();

            revenue.Items = "";
            revenue.Quantity = 0;
            revenue.Price = 0;
            
        }
        public void RevSelect()
        {
            //connectbetweenModelnterface();
            revenue.dataGridView = RevenueServices.RevenueSelect();
        }
    }
}
