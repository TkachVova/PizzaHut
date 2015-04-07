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
        PizzaHutRepository repo;
        public PizzaController()
        {
            repo = new PizzaHutRepository();
        }
        Lazy<List<order>> orderList = new Lazy<List<order>>();
        //get url api/api/pizza
        public IEnumerable<pizza> Get()
        {
            return repo.Pizzas.AsEnumerable();
        }


        //post url api/api/pizza
        public HttpResponseMessage Post (order _order)
        {
            //orderList.Value.Add(_order);
            //order in output line
            Debug.WriteLine("OOOOOORRRRDDDDEEEeeeeeeeeeeeeeeeeeeeeeeeeeeeeERRRR");
            Debug.WriteLine( _order.ToString());
            var response = Request.CreateResponse<order>(System.Net.HttpStatusCode.Created, _order);
            return response;
        }

    }
}
