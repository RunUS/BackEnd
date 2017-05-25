using Mars.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Repository.EFCodeFirst
{
    public class MarsContext : DbContext
    {
        public MarsContext()
            : base("MarsContext")
        {
        }

        public DbSet<Facility> Facilities { get; set; }
    }
}
