using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Mars.Services.Interfaces;
using Mars.Services;
using Ninject.Web.Common;
using Mars.Repository.EFCodeFirst;
using Mars.Repository.Interfaces;

namespace Mars.Core.IOC
{
    public class Settings
    {
        public static void Mapping(IKernel kernel)
        {
            //service
            kernel.Bind<IFacilityService>().To<FacilityService>();

            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            //repository
            kernel.Bind<MarsContext>().ToSelf().InRequestScope();
        }
    }
}
