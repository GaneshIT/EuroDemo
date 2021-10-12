using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementDataLayer
{
    public class Salesman
    {
        public int Salesman_id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public decimal Commission { get; set; }
    }
}
