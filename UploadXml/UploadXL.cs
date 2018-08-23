using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace UploadXml
{
    public class UploadXL
    {
        public void UploadFile(MultipartFormDataContent file)
        {
                
        /*    if (file.ContentLength > 0)
            {
                string ext = Path.GetExtension(file.ContentType);
                if (ext.Equals(".xlsx") || ext.Equals(".xlsm") || ext.Equals(".xltx") || ext.Equals(".xltm"))
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(HttpContext.Current.Server.MapPath("~/UploadedXml"), _FileName);
                    file.SaveAs(_path);
                }   
            }*/
        }
    }
}
