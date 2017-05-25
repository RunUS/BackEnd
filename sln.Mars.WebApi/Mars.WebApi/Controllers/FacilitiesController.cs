using Mars.Entities;
using Mars.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mars.WebApi.Controllers
{
    /// <summary>
    /// Get Facility related information
    /// </summary>
    public class FacilitiesController : ApiController
    {
        private IFacilityService FacilityService;
        public FacilitiesController(IFacilityService _FacilityService)
        {
            this.FacilityService = _FacilityService;

        }
        /// <summary>
        /// Get All facility Information
        /// </summary>
        /// <returns></returns>
        // GET api/values
        public IEnumerable<Facility> Get()
        {
            return FacilityService.GetFacilities();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}