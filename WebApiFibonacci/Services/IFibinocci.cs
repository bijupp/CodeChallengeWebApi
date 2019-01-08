using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFibonacci.Services
{
    public interface IFibinocci
    {
        string generateFibinocci(int length);
    }
}