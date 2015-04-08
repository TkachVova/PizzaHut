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
        public DbSet<cartItem> cartItems { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<pizza> pizzas { get; set; }
    }
}
