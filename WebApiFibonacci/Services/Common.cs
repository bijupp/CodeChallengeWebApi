using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiFibonacci.Models;

namespace WebApiFibonacci.Services
{
    public class Common :ICommon
    {
        public FinalResult getCompareResult(ListsToCompare compareList)
        {
            FinalResult ComparisonResult = new FinalResult();
            try
            {
                if (compareList != null && compareList.Current != null && compareList.Initial != null)
                {
                    List<BaseList> initial = new List<BaseList>();
                    List<BaseList> current = new List<BaseList>();

                    initial = compareList.Initial;
                    current = compareList.Current;

                    //new items to show with the newList list object
                    List<BaseList> newList = current.Where(n => !initial.Any(o => o.Key == n.Key)).ToList(); 

                    //updated items to show with the updatedList list object
                    List<BaseList> updatedList = current.Where(u => initial.Any(o => o.Key == u.Key && o.Value != u.Value)).ToList();

                    //deleted items to show with the deletedList list object
                    List<BaseList> deletedList = initial.Where(d => !current.Any(o => o.Key == d.Key)).ToList();

                    ComparisonResult.NewItems = newList;
                    ComparisonResult.UpdatedItems = updatedList;
                    ComparisonResult.DeletedItems = deletedList;
                    ComparisonResult.Message = "Success";

                }
                else
                {
                    ComparisonResult.Message = "Please provide valid input..";
                }
            }
            catch (Exception e)
            {
                ComparisonResult.Message = "Internal Error.";

            }
            return ComparisonResult;  //Request.CreateResponse<SortedCompareList>(HttpStatusCode.OK, ComparisonResult);  
        }

        
    }
}