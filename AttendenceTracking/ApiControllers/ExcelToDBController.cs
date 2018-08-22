using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ITracking.Bussiness;
using Tracking.Bussiness;
using Tracking.Entities;

namespace AttendenceTracking.ApiControllers
{
    
    public class ExcelToDBController : ApiController
    {
        private readonly ITrackingBusiness itrack;
        public ExcelToDBController(ITrackingBusiness track)
        {
            itrack = track;
        }
        [Route("api/ExcelToDB/ExcelBinding")]
        [HttpPost]
        public void ExcelBinding()
        {
            string path = "C:/Users/M1046631/Documents/Swipe details_dummy1";
            this.itrack.ExcelBinding(path);
        }
    }
}
