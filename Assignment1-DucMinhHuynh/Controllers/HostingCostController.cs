using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_DucMinhHuynh.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// set http request -> GET
        /// SET ROUTE controller(HostingCost) action(HostingCost_compute) param {id}
        /// send response to Browser combine all details into 1 string , send it back to brower.  
        /// </summary>
        /// <param name="id">0 ,14 , 15 , 21 , 28</param>
        /// <returns>6.22 , 12.43, 12.43, 12.43, 18.64</returns>
        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public string HostingCost_compute(int id)
        {   ///set all variables that we may need to do Math.
            int fornight = 0;
            double cost_fornight = 0;
            string result = "";
            double tax = 0;
            double total_cost = 0;
            /// because fornight is int variable so it won't take 2 decimal , and +1   
            fornight = id / 14 + 1;
            cost_fornight = fornight * 5.50; 
            tax = cost_fornight * 0.13;
            total_cost = tax + cost_fornight;
            result = fornight + "fortnights at $5.50/FN = $" + Math.Round(cost_fornight, 2) + "CAD\n “HST 13% = $" + Math.Round(tax, 2) + "CAD\nTotal = $" + Math.Round(total_cost, 2) + "CAD";
            return result;
        }
    }
}
