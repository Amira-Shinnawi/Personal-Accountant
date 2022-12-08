using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Accountant.Models
{
    public class Expenses_model
    {
        public string Items { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime AddedDate { get; }
    }
}
