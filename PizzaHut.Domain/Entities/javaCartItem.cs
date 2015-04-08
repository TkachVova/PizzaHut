using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHut.Domain.Entities
{
    public class javacartItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        
        //for outputting in Debug
        public override string ToString()
        {
            return "cart item id  " + id.ToString() + "  " + name + "  " + price.ToString() + "  " + quantity.ToString();
        }
    }
}
