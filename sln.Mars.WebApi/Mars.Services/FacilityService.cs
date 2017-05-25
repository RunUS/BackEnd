using Mars.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars.Entities;

namespace Mars.Services
{
    public class FacilityService : IFacilityService
    {
        public IEnumerable<Facility> GetFacilities()
        {
            return new List<Facility>() { new Facility() { Id= Guid.NewGuid(), Address="shanghai", Name="xxx hospital"} }.AsEnumerable();
        }
    }
}
