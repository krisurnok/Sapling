using Microsoft.AspNet.Identity;
using SaplingBL.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Sapling.Controllers
{
    public class HomeController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetSaplings(SaplingViewModal saplingViewModal)
        {
            HttpResponseMessage response;
            try
            {
                Guid loggedUserId = User.Identity.IsAuthenticated? Guid.Parse(User.Identity.GetUserId()) : default(Guid);
                var result = new List<SaplingViewModal>(); //SaplingFacade.GetSaplings(loggedUserId, saplingViewModal., longitude, isAll);
                response = Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return response;
        }


    }
}
