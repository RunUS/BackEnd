using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Mars.Services.Interfaces;
using Mars.Services;
using Ninject.Web.Common;

namespace Mars.Core.IOC
{
    public class Settings
    {
        public static void Mapping(IKernel kernel)
        {
            kernel.Bind<IFacilityService>().To<FacilityService>().InRequestScope();
        }
    }
}
