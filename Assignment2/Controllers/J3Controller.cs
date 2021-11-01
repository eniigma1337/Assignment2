using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">first distance between consecutive cities </param>
        /// <param name="b">second distance between consecutive cities </param>
        /// <param name="c">third distance between consecutive cities </param>
        /// <param name="d">fourth distance between consecutive cities </param>
        /// <example>
        /// GET: api/J3/CityDistance/3 /10 /12 /5
        ///</example>
        /// <returns> 
        /// 0 3 13 25 30
        /// 3 0 10 22 27
        /// 13 10 0 12 17
        /// 25 22 12 0 5
        /// 30 27 17 5 0
        ///</returns>
        //GET: api/J3/CityDistance
        [HttpGet]
        [Route("api/J3/CityDistance/{a}/{b}/{c}/{d}")]
        public string CityDistance(int a, int b, int c, int d)
        {
            string message = "<br/>";
            int[,] arr = new int[5, 5] { { 0, a,a+b,a+b+c,a+b+c+d }, { a,0,b,b+c,b+c+d }, { a+b, b,0,c,c+d }, { a+b+c,b+c,c,0,d },{a+b+c+d,b+c+d,c+d,d,0 } };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    message = message+ arr[i,j] +" ";
                }
                message = message + Environment.NewLine;
            }
            return message;

        }
    }
}

