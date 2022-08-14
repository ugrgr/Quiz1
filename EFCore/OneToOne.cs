using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EFCore.OneToOne;

namespace EFCore
{
    public class OneToOne
    {
        public class City
        {
            public int Id { get; set; }

            public string ?Name { get; set; }

            public int CityInformationId { get; set; }

            public CityInformation ?CityInformation { get; set; }
        }

        public class CityInformation
        {
            public int Id { get; set; }

            public int Population { get; set; }

            public string ?OtherName { get; set; }

            public string ?MayorName { get; set; }

            public City ?City { get; set; }
        }
    }

    
public class CompanyContext : DbContext
    {
        public DbSet<City> ?City { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JIFTFVO\UGURGUR;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                 modelBuilder.Entity<City>()
                .HasOne(e => e.CityInformation)
                .WithOne(e => e.City)
                .HasForeignKey<City>(e => e.CityInformationId);
        }
    }

}
