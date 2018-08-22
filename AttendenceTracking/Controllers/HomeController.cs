using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttendenceTracking.ApiControllers;
using System.Net.Http.Headers;
using System.Net.Http;
using ITracking.Bussiness;
using Tracking.Entities;

namespace AttendenceTracking.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ITrackingBusiness itrack;
        
        public ActionResult Index()
        {
 
            StringContent stringcontent = new StringContent("C:/Users/M1047044/Documents/Swipe details_dummy1");
            System.Net.Http.HttpClient client = new HttpClient();
             client.BaseAddress = new Uri("http://localhost:64482/");
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
             HttpResponseMessage response = client.PostAsync("api/ExcelToDB/ExcelBinding",stringcontent).Result;
          //  var list = new ExcelToDBController.ExcelBinding( itrack);
            return View();
        }
        
    }
}
