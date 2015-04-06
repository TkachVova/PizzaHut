using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PizzaHutWebApi.Models;
using System.Diagnostics;

namespace PizzaHutWebApi.Controllers
{
    public class PizzaController : ApiController
    {
        Lazy<List<order>> orderList = new Lazy<List<order>>();
        public pizza[] Get()
        {
            return new pizza[]
                {
                     new pizza { id =1 , ingridients="Classic marinara sauce, pepperoni, seasoned pork, beef, fresh mushrooms, fresh green bell peppers and fresh red onions.", name="America", price = 100},
                     new pizza { id =2 , ingridients="Classic marinara sauce, pepperoni, seasoned pork, beef, fresh mushrooms, fresh green bell peppers and fresh red onions.", name="America", price = 200},
                     new pizza { id =3 , ingridients="Classic marinara sauce, pepperoni, seasoned pork, beef, fresh mushrooms, fresh green bell peppers and fresh red onions.", name="America", price = 300}
                };
        }

        public HttpResponseMessage Post (order _order)
        {
            //orderList.Value.Add(_order);
            Debug.WriteLine("OOOOOORRRRDDDDEEEeeeeeeeeeeeeeeeeeeeeeeeeeeeeERRRR");
            Debug.WriteLine( _order.ToString());
            var response = Request.CreateResponse<order>(System.Net.HttpStatusCode.Created, _order);
            return response;
        }

    }
}
