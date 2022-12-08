using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Accountant.Views.Interface
{
    interface IEmployee
    {
        string EmpName { get; set; }
        string Gender { get; set; }
        double Salary { get; set; }
        string PhoneNum { get; set; }
        object dataGridView { get; set; }
    }
}
