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
    [RoutePrefix("api/ufo")]
    public class UFOController : ApiController
    {
        NightSkyObservatoryEntitiesConnection db = new NightSkyObservatoryEntitiesConnection();

        // Fill UFO dropdown menu 
        //[Route("state")]
        [HttpGet]
        public IEnumerable<object> GetStates()
        {
            var UFOMenuQuery =
                from ufo in db.UFOes
                orderby ufo.State ascending
                select new
                {
                    ufo.State
                };

            var ufoState = UFOMenuQuery;
            return ufoState.Distinct().ToList();
        }



    }
}
