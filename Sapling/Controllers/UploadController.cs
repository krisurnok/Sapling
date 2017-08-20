using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Sapling.Controllers
{
    public class UploadController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Upload()
        {
            HttpResponseMessage response;
            try
            {
                var httpRequest = HttpContext.Current.Request;
                if (httpRequest.Files.Count > 0)
                {

                }

                response = Request.CreateResponse(HttpStatusCode.OK, "");
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return response;
        }
    }
}
