using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_DucMinhHuynh.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// set http request -> POST
        /// SET ROUTE controller(Greeting) action(sayHello)
        /// send response to Browser (String message "helloworld")
        /// </summary>
        /// <param name="id"></param>
        /// <returns>"HelloWorld";</returns>
        [HttpPost]
        [Route("api/Greeting")]
        public string sayHello()
        {
            return "HelloWorld";
        }


        /// <summary>
        /// set http request -> GET
        /// SET ROUTE controller(Greeting) action(sayHelloToPeople) param({id})
        /// send response to Browser (string + id )
        /// </summary>
        /// <param name="id">  3 , 6 , 0</param>
        /// <returns>"Greetings to 3 people!"; "Greetings to 6 people!";"Greetings to 0 people!"</returns>
        [HttpGet]
        [Route("api/Greeting/{id}")]
        public string sayHelloToPeople( int id)
        {
            return "Greeting to "+ id + " people!";
        }



    }
}
