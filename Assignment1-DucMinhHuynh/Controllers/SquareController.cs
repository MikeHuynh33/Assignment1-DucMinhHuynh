using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_DucMinhHuynh.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// set http request -> GET
        /// SET ROUTE controller(Square) action(Square_compute) param {id}
        /// send response to Browser (input * input)
        /// </summary>
        /// <param name="id">2 ,-2 , 10 </param>
        /// <returns>4 , 4 ,100</returns>
        [HttpGet]
        [Route("api/Square/{id}")]
        public int Square_compute(int id)
        {
            return id * id;
        }
    }
}
