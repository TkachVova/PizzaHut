using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaHut.Domain.Entities;

namespace PizzaHut.Domain.Concrete
{
    //class which provides access to PizzaHutDb
    public class PizzaHutRepository
    {
        private PizzaHutDbContext context = new PizzaHutDbContext();
        //get all pizzas
        public IQueryable<pizza> Pizzas 
        {
            get { return context.pizzas;}
        }

        public IQueryable<customer> Customers
        {
            get { return context.customers; }
        }

        public IQueryable<order> Orders
        {
            get { return context.orders; }
        }
        //add new to pizzas
        public void CreatePizza(pizza _pizza)
        {
            context.pizzas.Add(_pizza);
            context.SaveChanges();
        }
        //find pizza in pizzas
        public pizza getPizzaById(int pid)
        {
            return context.pizzas.Where(p => p.id == pid).SingleOrDefault();
        }
        //edit cur pizza
        public void EditPizza(pizza _pizza)
        {
            pizza pOld = context.pizzas.Where(x => x.id == _pizza.id).SingleOrDefault();
            if (pOld != null)
            {
                context.Entry(pOld).CurrentValues.SetValues(_pizza);
                context.SaveChanges();
            }
        }

        public void CreateCustomer(string name, string phone)
        {
            customer cust = new customer();
            cust.name = name;
            cust.phone = phone;
            cust.id = 1;
            context.customers.Add(cust);
            context.SaveChanges();
        }

        public void CreateOrder(javaOrder _order)
        {
            order ord = new order();
            ord.customerId = context.customers.Max(p => p.id);
            ord.deliveryAddress = _order.deliveryAddress;
            ord.fullprice = _order.items.Sum(p  => p.price*p.quantity);
            ord.processing = true;
            ord.orderTime = DateTime.Now;
            context.orders.Add(ord);
            context.SaveChanges();
        }

        public void CreateOrderItem(int orderId, int pizId, int amount)
        {
            cartItem newItem = new cartItem();
            newItem.orderId = orderId;
            newItem.pizzaId = pizId;
            newItem.quantity = amount;
            context.cartItems.Add(newItem);
            context.SaveChanges();
        }

        //takes received(from the fronend) order, and put it in all entities of relational db PizzaHutDb
        public void TakeOrder(javaOrder _order)
        {
            CreateCustomer(_order.client.name, _order.client.phone);
            CreateOrder(_order);
            int orderId = context.orders.Max(p => p.id);
            foreach (var oitem in _order.items)
            {
                CreateOrderItem(orderId, context.pizzas.Where(p => p.name == oitem.name).SingleOrDefault().id, oitem.quantity);
            }
        }
    }
}
