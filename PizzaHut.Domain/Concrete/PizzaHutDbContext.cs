using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaHut.Domain.Entities;
using System.Data.Entity;

namespace PizzaHut.Domain.Concrete
{
    public class PizzaHutDbContext : DbContext
    {
        public DbSet<pizza> pizzas { get; set; }
    }
}
