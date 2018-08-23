using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Tracking.Bussiness;

namespace AttendenceTracking.ApiControllers
{
    public class UploadXlController : ApiController
    {
        private readonly TrackingBussiness track = new TrackingBussiness();
      
        [Route("api/UploadXl/UploadXL")]
        [HttpPost]
        public void UploadXL(MultipartFormDataContent file)
        {
            track.UploadXL(file);
        }
    }
}
