using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFibonacci.Services;

namespace WebApiFibonacci.Controllers
{
    public class FibonacciController : ApiController
    {
        /// <summary>
        /// The get method will generate the fibinacci series number
        /// upto a length of the input "num"
        /// </summary>
        /// <param name="length">It is the length of the fibinacci series</param>
        /// <returns></returns>
        public string Get(int num)
        {
            string FibinocciSeries = "";
            if (num > 0)
            {
                try
                {
                    //point interface "IFibinocci" to the class object "Fibinocci"
                    IFibinocci fibinocci = new Fibinocci();
                    FibinocciSeries = fibinocci.generateFibinocci(num);
                    return FibinocciSeries;
                }
                catch (Exception ex)
                {

                    return ex.InnerException.ToString();
                }
            }
            else
            {
                return "Please provide a number greater than zero";
            }
        }

    }
}
