using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.Entities;

namespace Tracking.DataAccessLayer.IService.Respository
{
    public interface IServiceExcelBinding
    {
        void ExcelBinding(BindingList<GlcSwipe> glcList);
    }
}
