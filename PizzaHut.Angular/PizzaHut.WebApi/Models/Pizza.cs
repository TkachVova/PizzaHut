using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaHut.WebApi.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public string PizzaIngridients { get; set; }
        public int PizzaPrice { get; set; }
    }
}