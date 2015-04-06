using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaHutWebApi.Models
{
    public class Client
    {
        public int id { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return "id = " + id + "  " + name.ToString();
        }
    }
}