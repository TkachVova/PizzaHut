﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHut.Domain.Entities
{
    //class for receiving order information from frontend in api controller
    public class javaOrder
    {
        //for storing information about clients
        public customer client { get; set; }
        //delivery address is not in customer because it can be always different
        public string deliveryAddress { get; set; }
        public IEnumerable<javacartItem> items { get; set; }
        public override string ToString()
        {
            string ret = client.ToString();
            foreach (var item in items)
            {
                ret += "  " + item.ToString();
            }
            return ret;
        }
    }
}
