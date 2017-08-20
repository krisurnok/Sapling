using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using SaplingBL.BL;


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
                long saplingid = 0;
                var httpRequest = HttpContext.Current.Request;
                if (httpRequest.Files.Count > 0)
                {
                    byte[] fileData = null;
                    using (var binaryReader = new BinaryReader(httpRequest.Files[0].InputStream))
                    {
                        fileData = binaryReader.ReadBytes(httpRequest.Files[0].ContentLength);
                    }
                    Guid loggedUserId = default(Guid);
                    if (loggedUserId == default(Guid))
                    {
                        Guid.TryParse("5F246DDC-B744-46BC-8C90-E431A9264326", out loggedUserId);
                    }
                     saplingid = SaplingFacade.UploadImage(loggedUserId, fileData);
                }

                response = Request.CreateResponse(HttpStatusCode.OK, saplingid);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return response;
        }
    }
}
