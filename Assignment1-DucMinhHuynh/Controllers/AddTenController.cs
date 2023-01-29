using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_DucMinhHuynh.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// set http request -> GET
        /// SET ROUTE controller(AddTen) action(Addten_compute) param {id}
        /// send response to Browser (input + 10)
        /// </summary>
        /// <param name="id">21 ,0 , 10 </param>
        /// <returns>31 , 10 ,0</returns>
        [HttpGet]
        [Route("api/AddTen/{id}")]
        public int Addten_compute(int id)
        {
            return id + 10;
        }
    }
}
