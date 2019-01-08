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
    public class CommonController : ApiController
    {
        /// <summary>
        /// Post method to get the comparison list from the input list objects
        /// </summary>
        /// <param name="listsToCompare"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Post ([FromBody]ListsToCompare listsToCompare)
        {
            FinalResult ComparisonResult = new FinalResult();
            try
            {
                ICommon common = new Common();
                ComparisonResult = common.getCompareResult(listsToCompare);
                ComparisonResult.Message = "Result generated successfully";
            }
            catch (Exception ex)
            {

                ComparisonResult.Message = "Could not generate result, exception occured " + ex.InnerException;
            }
            return Request.CreateResponse<FinalResult>(HttpStatusCode.OK, ComparisonResult);
        }

    }
}
