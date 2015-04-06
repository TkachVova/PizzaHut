using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaHutWebApi.Models
{
    public class pizza
    {
        public int id { get; set; }
        public string name { get; set; }
        public string ingridients { get; set; }
        public int price { get; set; }
    }
}