using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaHut.Domain.Entities;

namespace PizzaHut.Domain.Concrete
{
    public class PizzaHutRepository
    {
        private PizzaHutDbContext context = new PizzaHutDbContext();
        public IQueryable<pizza> Pizzas 
        {
            get { return context.pizzas;}
        }
    }
}
