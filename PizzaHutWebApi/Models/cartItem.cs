using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaHutWebApi.Models
{
    public class cartItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public override string ToString()
        {
            return "cart item id  " + id.ToString() + "  " + name + "  " + price.ToString() + "  " + quantity.ToString() ;
        }
    }
}