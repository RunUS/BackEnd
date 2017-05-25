using Mars.Entities;
using Mars.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mars.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        private IFacilityService FacilityService;
        public ValuesController(IFacilityService _FacilityService)
        {
            this.FacilityService = _FacilityService;

        }
        // GET api/values
        public IEnumerable<Facility> Get()
        {
            return FacilityService.GetFacilities();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
