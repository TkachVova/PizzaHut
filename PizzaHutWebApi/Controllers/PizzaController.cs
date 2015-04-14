using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using PizzaHutWebApi.Models;
using System.Diagnostics;
using PizzaHut.Domain.Entities;
using PizzaHut.Domain.Concrete;

namespace PizzaHutWebApi.Controllers
{
    public class PizzaController : ApiController
    {
        //do dependency injection later
        PizzaHutRepository repo;
        public PizzaController()
        {
            repo = new PizzaHutRepository();
            foreach (var pizza in repo.Pizzas)
            {
                Debug.WriteLine(pizza.ToString());
            }
            foreach (var cust in repo.Customers)
            {
                Debug.WriteLine(cust.ToString());
            }
        }
        Lazy<List<javaOrder>> orderList = new Lazy<List<javaOrder>>();
        //get url api/api/pizza
        public IEnumerable<pizza> Get()
        {
            return repo.Pizzas.AsEnumerable();
        }


        //post url api/api/pizza
        public HttpResponseMessage Post (javaOrder _order)
        {
            //orderList.Value.Add(_order);
            //order in output line
            Debug.WriteLine("OOOOOORRRRDDDDEEEeeeeeeeeeeeeeeeeeeeeeeeeeeeeERRRR");
            Debug.WriteLine( _order.ToString());
            repo.TakeOrder(_order);
            var response = Request.CreateResponse<javaOrder>(System.Net.HttpStatusCode.Created, _order);
            return response;
        }

    }
}
