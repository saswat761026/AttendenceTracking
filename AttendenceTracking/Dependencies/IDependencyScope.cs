﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendenceTracking.Dependencies
{
    interface IDependencyScope:IDisposable{
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}
