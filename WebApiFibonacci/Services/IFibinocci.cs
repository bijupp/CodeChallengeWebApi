using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFibonacci.Models;

namespace WebApiFibonacci.Services
{
    public interface IFibinocci
    {
        Fibonacci generateFibinocci(int length);
    }
}