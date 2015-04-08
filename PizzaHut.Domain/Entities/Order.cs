using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHut.Domain.Entities
{
    public class order
    {
        public int id { get; set; }
        public bool processing { get; set; }
        public int customerId { get; set; }
        public decimal fullprice { get; set; }
        public string deliveryAddress { get; set; }
        public System.DateTime orderTime { get; set; }
    }
}
