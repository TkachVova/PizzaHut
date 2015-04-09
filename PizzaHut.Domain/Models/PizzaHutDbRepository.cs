using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaHut.Domain.Models
{
    public class PizzaHutDbRepository
    {
        PizzaHutDbEntities context;
        public PizzaHutDbRepository()
        {
            context = new PizzaHutDbEntities();
        }

        public IQueryable<pizzas> Pizzas
        {
            get { return context.pizzas; }
        }

    }
}
