using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiFibonacci.Models;
using WebApiFibonacci.Services;

namespace WebApiFibonacci.Controllers
{
    public class FibonacciController : ApiController
    {
        /// <summary>
        /// The get method will generate the fibinacci series number
        /// upto a length of the input "num"
        /// </summary>
        /// <param name="num">It is the length of the fibinacci series</param>
        /// <returns></returns>
        public Fibonacci Get(int num)
        {
            Fibonacci _fibonacci = new Fibonacci();
            if (num > 0)
            {
                try
                {
                    //point interface "IFibinocci" to the class object "Fibinocci"
                    IFibinocci fibinocci = new Fibinocci();
                    _fibonacci = fibinocci.generateFibinocci(num);
                    return _fibonacci;
                }
                catch (Exception ex)
                {
                    _fibonacci.Message = ex.InnerException.ToString();
                    return _fibonacci;
                }
            }
            else
            {
                _fibonacci.Message = "Please provide a number greater than zero";
                return _fibonacci;
            }
        }

    }
}
