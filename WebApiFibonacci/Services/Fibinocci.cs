using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

            fibnoSeries = "fibonacci:" + firstFibno.ToString() + "," + nextFibno.ToString();
            for (int start = 0; start <= length; start++)
            {
                currentFibno = firstFibno + nextFibno;
                fibnoSeries = fibnoSeries + "," + currentFibno.ToString();

                firstFibno = nextFibno;
                nextFibno = currentFibno;
            }
            return fibnoSeries;
        }
    }
}