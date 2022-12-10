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
    class EmployeePresenter
    {
        IEmployee employee;
        Employee_model EmpModel = new Employee_model();

        public EmployeePresenter(IEmployee view)
        {
            this.employee = view;
        }
        private void connectbetweenModelnterface()
        {
        
            EmpModel.EmpName = employee.EmpName;
            EmpModel.Gender = employee.Gender;
            EmpModel.Salary = employee.Salary;
           

        }
        public bool EmpInsert()
        {
            connectbetweenModelnterface();
            bool check = EmployeeServices.EmployeeInsert(employee.EmpName, employee.Gender
                                                 , employee.Salary, employee.PhoneNum);
            EmpSelect();
            ClearFileds();
            return check;
        }
        public bool EmpUpdate()
        {
            connectbetweenModelnterface();
            bool check = EmployeeServices.EmployeeUpdate(employee.EmpName, employee.Gender
                                                 , employee.Salary, employee.PhoneNum);
            EmpSelect();
            ClearFileds();
            return check;
        }
        public bool EmpDelete()
        {
            connectbetweenModelnterface();
            bool check = EmployeeServices.EmployeeDelete(employee.EmpName);
            EmpSelect();
            ClearFileds();
            return check;
        }
        public bool EmpReset()
        {
            connectbetweenModelnterface();
            bool check = EmployeeServices.EmployeeReset();
            EmpSelect();
            ClearFileds();
            return check;
        }
        public void ClearFileds()
        {
            connectbetweenModelnterface();

            employee.EmpName = "";
            employee.Gender = "";
            employee.Salary = 0;
            employee.PhoneNum = "+20 ";

        }
        public void EmpSelect()
        {
            //connectbetweenModelnterface();
            employee.dataGridView = EmployeeServices.EmployeeSelect();
        }

    }
}
