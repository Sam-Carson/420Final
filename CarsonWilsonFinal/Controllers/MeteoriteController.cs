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
    [RoutePrefix("api/meteorite")]

    public class MeteoriteController : ApiController
    {
        NightSkyObservatoryEntitiesConnection db = new NightSkyObservatoryEntitiesConnection();

        // Fill Meteorite dropdown menu 
        //[Route("classification")]
        [HttpGet]
        public IEnumerable<object> GetClassifications()
        {
            var MeteoriteClassificationQuery =
                from meteorite in db.Meteorites
                orderby meteorite.Classification ascending
                select new
                {
                    meteorite.Classification
                };

            var MeteoriteClassification = MeteoriteClassificationQuery;
            return MeteoriteClassification.Distinct().ToList();
        }
    }
}
