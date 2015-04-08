using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaHut.Domain.Entities
{
    public class cartItem
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public int pizzaId { get; set; }
        public int quantity { get; set; }
    }
}
