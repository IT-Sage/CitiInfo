using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiInfo.API.Entities
{
    public class CityInfoContext : DbContext
    {
        // kind of injected DbContext
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        {            
            Database.EnsureCreated();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        //2nd option of setting DbContext, not consistent with Dependency Injection
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
