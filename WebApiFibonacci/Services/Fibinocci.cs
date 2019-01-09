using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFibonacci.Models;

namespace WebApiFibonacci.Services
{
    public class Fibinocci: IFibinocci
    {
        public string generateFibinocci(int length)
        {
            int firstFibno = 0;
            int nextFibno = 1;
            int currentFibno = 0;
            string fibnoSeries = "";

            Fibonacci fibinocciResult = new Fibonacci();
            List<int> fibonacciSeries = new List<int>();

            fibonacciSeries.Add(firstFibno);
            fibonacciSeries.Add(nextFibno);

            fibnoSeries = "fibonacci:" + firstFibno.ToString() + "," + nextFibno.ToString();
            for (int start = 0; start <= length; start++)
            {
                currentFibno = firstFibno + nextFibno;
                fibonacciSeries.Add(currentFibno);
                firstFibno = nextFibno;
                nextFibno = currentFibno;
            }
            fibinocciResult.fibonacci = fibonacciSeries;
            fibinocciResult.Message = "Fibonacci series generates successfully";
            fibnoSeries = "fibonacci:" + string.Join(",",fibinocciResult.fibonacci.ToArray());
            return fibnoSeries;
        }
    }
}