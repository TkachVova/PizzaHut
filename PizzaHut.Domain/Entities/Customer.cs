using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHut.Domain.Entities
{
    public class customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }

        public override string ToString()
        {
            return "Customer" + id.ToString() + " : " + name + "  " + phone;
        }
    }
}
