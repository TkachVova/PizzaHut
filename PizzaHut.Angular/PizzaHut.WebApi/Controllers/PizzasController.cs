using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PizzaHut.WebApi.Models;

namespace PizzaHut.WebApi.Controllers
{
    public class PizzasController : ApiController
    {
        public static Lazy<List<Pizza>> pizzaList = new Lazy<List<Pizza>>();
        public static Lazy<List<Pizza>> pizzaBox = new Lazy<List<Pizza>>();
        public static int PageLoadFlag = 1; 
        public PizzasController()
        {
            //use one time
            if (PageLoadFlag == 1)
            {
                pizzaList.Value.Add(new Pizza { PizzaId = 1, PizzaName = "Four Cheeses", PizzaIngridients = "A lot of cheese", PizzaPrice = 100 });
                pizzaList.Value.Add(new Pizza { PizzaId = 2, PizzaName = "Four Cheeses", PizzaIngridients = "A lot of cheese", PizzaPrice = 101 });
                pizzaList.Value.Add(new Pizza { PizzaId = 3, PizzaName = "Four Cheeses", PizzaIngridients = "A lot of cheese", PizzaPrice = 102 });
                pizzaList.Value.Add(new Pizza { PizzaId = 4, PizzaName = "Four Cheeses", PizzaIngridients = "A lot of cheese", PizzaPrice = 103 });
                pizzaList.Value.Add(new Pizza { PizzaId = 5, PizzaName = "Four Cheeses", PizzaIngridients = "A lot of cheese", PizzaPrice = 104 });
                pizzaList.Value.Add(new Pizza { PizzaId = 6, PizzaName = "Four Cheeses", PizzaIngridients = "A lot of cheese", PizzaPrice = 105 });
                pizzaList.Value.Add(new Pizza { PizzaId = 7, PizzaName = "Four Cheeses", PizzaIngridients = "A lot of cheese", PizzaPrice = 106 });
                pizzaList.Value.Add(new Pizza { PizzaId = 8, PizzaName = "Four Cheeses", PizzaIngridients = "A lot of cheese", PizzaPrice = 107 });
                pizzaList.Value.Add(new Pizza { PizzaId = 9, PizzaName = "Four Cheeses", PizzaIngridients = "A lot of cheese", PizzaPrice = 108 });
                PageLoadFlag++;
            }
        }

        [HttpGet]
        [Route("pizzas")]
        public IEnumerable<Pizza> GetPizzas()
        {
            return pizzaList.Value.AsEnumerable();
        }

    }
}
