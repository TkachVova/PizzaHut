using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaHutWebApi.Models
{
    public class order
    {
        public string userName { get; set; }
        public string userAddress { get; set; }
        public string userPhone { get; set; }
        public IEnumerable<cartItem> items { get; set; }
        public override string ToString()
        {
            string ret = userName + "  " + userAddress + "  " + userPhone;
            foreach (var item in items)
            {
                ret += "  " + item.ToString();
            }
            return ret;
        }
    }
}