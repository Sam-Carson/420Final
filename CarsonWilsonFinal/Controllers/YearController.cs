using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;


namespace CarsonWilsonFinal.Controllers
{
    [RoutePrefix("api/year")]

    public class YearController : ApiController
    {
        NightSkyObservatoryEntitiesConnection db = new NightSkyObservatoryEntitiesConnection();

        // Fill Year dropdown menu 
        //[Route("year")]
        [HttpGet]
        public IEnumerable<object> GetYears()
        {
            var YearQuery =
                from years in db.Years
                orderby years.Year1 descending
                select new
                {
                    years.Year1
                };

            var Years = YearQuery;
            return Years.Distinct().ToList();
        }
    }
}
