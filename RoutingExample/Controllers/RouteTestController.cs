using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoutingExample.Controllers
{
    public class RouteTestController : ApiController
    {

        //GET: api/RouteTest/Math/x/y -> x*y
        [HttpGet]
        [Route("api/RouteTest/Math/{operand1}/{operand2}")]
        public int Math(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        //GET: api/RouteTest/Greeting2 -> "howdy"
        [HttpGet]
        public string Greeting2()
        {
            return "howdy";
        }


        //POST: api/RouteTest/Greeting3 -> "Heya"
        public string Greeting3()
        {
            return "Heya";
        }

        //POST: api/RouteTest/Greeting4 -> "Hola"
        public string Greeting4()
        {
            return "Hola";
        }

        
    }
}
