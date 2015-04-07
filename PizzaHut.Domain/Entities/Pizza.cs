using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHut.Domain.Entities
{
    public class pizza
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ingridients { get; set; }
        public decimal price { get; set; }
    }
}
