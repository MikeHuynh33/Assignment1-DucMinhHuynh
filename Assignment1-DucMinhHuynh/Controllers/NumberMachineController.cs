using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_DucMinhHuynh.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// set http request -> GET
        /// SET ROUTE controller(NumberMachine) action(operator_compute) param {id}
        /// send response to Browser ((input * input)/ input + (input * 2 - input)
        /// </summary>
        /// <param name="id">10 ,-5 , 10 </param>
        /// <returns>20 , -10 ,60</returns>
        [HttpGet]
        [Route("api/NumberMachine/{id}")]
        public int operator_compute(int id)
        {
            return (id * id)/ id + (id * 2 - id)  ;
        }
    }
}
