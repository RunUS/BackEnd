using Mars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Services.Interfaces
{
    public interface IFacilityService
    {
        IEnumerable<Facility> GetFacilities();
    }
}
