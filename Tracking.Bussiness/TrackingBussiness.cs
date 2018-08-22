using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Tracking.Entities;
using ITracking.Bussiness;
using ReadXL.Handler;
using Tracking.DataAccessLayer.Service.Respository;
using System.ComponentModel;

namespace Tracking.Bussiness
{
    public class TrackingBussiness
    {
        private readonly ServiceExcelBinding iservicetrack = new ServiceExcelBinding();
        public TrackingBussiness()
        {
        
        }
        public void ExcelBinding(string path)
        {
            BindingList<GlcSwipe> glcList = new BindingList<GlcSwipe>(); 
            ReadXL.Handler.ReadXL xl = new ReadXL.Handler.ReadXL();
            glcList = xl.ExcelToDb(path);
            foreach(var swipe in glcList)
            {
                string[] arr = swipe.Location.Split(' ');
                swipe.I_O = arr[arr.Length - 1];
                arr = arr.Take(arr.Count() - 1).ToArray();
                swipe.Location = String.Join(" ", arr);

                //DateTime check = new DateTime()
                if (swipe.I_O == "IN")
                {
                    if (String.Compare(swipe.Datetime.ToLongTimeString(), "8:30:00") > 0)
                    {
                        swipe.Swipetype = "Swipe Late";
                    }
                    else
                    {
                        swipe.Swipetype = "Swipe On Time";
                    }
                }
                else {
                    swipe.Swipetype = "N/A";
                }
            }
            iservicetrack.ExcelBinding(glcList);
        }
    }
}
