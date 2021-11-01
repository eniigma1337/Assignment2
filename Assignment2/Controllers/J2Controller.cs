using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m">first die sides</param>
        /// <param name="n">second die sides</param>
        /// <example>
        /// GET: api/J2/TwoDiceGame/6/8
        ///</example>
        /// <returns>There are 5 total ways to get the sum 10.</returns>
        //GET: api/j2/TwoDiceGame
        [HttpGet]
        [Route("api/J2/TwoDiceGame/{m}/{n}")]
        public string TwoDiceGame(int m, int n)
        {
            int total = 0;
            int sum = 10;
            for (int i = 1; i < Math.Min(sum, m + 1); i++)
            {
                if ((sum - i) <= n)
                {
                    total++;
                }
            }

            string message = "There are " + total+ " ways to get the sum " + sum;
            return message;

        }
    }
}
