using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttendenceTracking.ApiControllers;
using System.Net.Http.Headers;
using System.Net.Http;
using Tracking.Bussiness;
using Tracking.Entities;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace AttendenceTracking.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrackingBussiness itrack = new TrackingBussiness();
        [Route("Index")]
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
        [Route("Upload")]
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }
        [Route("Upload")]
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {


              System.Net.Http.HttpClient client = new HttpClient();
              client.BaseAddress = new Uri("http://localhost:64482/");

              var requestContent = new MultipartFormDataContent();
              var fileContent = new StreamContent(file.InputStream);
              fileContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
              requestContent.Add(fileContent, file.FileName, file.FileName);
            
            itrack.UploadXL(requestContent);
              // Add an Accept header for JSON format.
              //client.DefaultRequestHeaders.Accept.Add(
              //new MediaTypeWithQualityHeaderValue("application/json"));
              //HttpResponseMessage response = client.PostAsync("api/UploadXl/UploadXL", requestContent).Result;
              //ViewBag.Message = "File upload failed!!";
              
          /*  if (file.ContentLength > 0)
            {

                    string _FileName = DateTime.Now.ToString();// Path.GetFileName(file.FileName);
                    string _path = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/UploadedXml"), _FileName);
                    file.SaveAs(_path);
                
            }*/
            return View();
        }
        
    }
}