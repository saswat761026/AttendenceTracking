using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.DataAccessLayer.IService.Respository;
using Tracking.Entities;
using Tracking.DataAccessLayer.DbContext;
using System.Data.Entity;

namespace Tracking.DataAccessLayer.Service.Respository
{
    public class ServiceExcelBinding : IServiceExcelBinding
    {
        private readonly TrackingDbContext dbContext;
        public ServiceExcelBinding() {
            dbContext = new TrackingDbContext();
        }
        public void ExcelBinding(BindingList<GlcSwipe> glcList)
        {
            this.dbContext.glcswipes.AddRange(glcList);
            this.dbContext.SaveChanges();
            //foreach (var glc in glcList)
            //{
            //    this.dbContext.glcswipes.Add(glc);
            //    this.dbContext.SaveChanges();
            //}

        }
    }
}
