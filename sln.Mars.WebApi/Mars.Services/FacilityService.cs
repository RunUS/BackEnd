using Mars.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars.Entities;
using Mars.Repository.Interfaces;

namespace Mars.Services
{
    public class FacilityService : IFacilityService
    {
        private IRepository<Facility> facilityRepository;
        public FacilityService(IUnitOfWork _uow)
        {
            facilityRepository = _uow.Repository<Facility>();
        }
        public IEnumerable<Facility> GetFacilities()
        {
            return facilityRepository.Table.AsEnumerable();
        }
    }
}
