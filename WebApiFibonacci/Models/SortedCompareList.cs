using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiFibonacci.Models
{
    public class SortedCompareList
    {
        public List<BaseList> NewItems { get; set; }
        public List<BaseList> UpdatedItems { get; set; }
        public List<BaseList> DeletedItems { get; set; }
        public string Message { get; set; }
    }
}