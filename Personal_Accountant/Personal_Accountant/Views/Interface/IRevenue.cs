using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Accountant.Views.Interface
{
    interface IRevenue
    {
        string Items { get; set; }
        int Quantity { get; set; }
        int Price { get; set; }
        DateTime AddedDate { get; }
        object dataGridView { get; set; }
    }
}
