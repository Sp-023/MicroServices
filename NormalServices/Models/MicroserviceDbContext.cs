using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NormalServices.Models
{
    public class MicroserviceDbContext:DbContext
    {

        public MicroserviceDbContext(DbContextOptions<MicroserviceDbContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HP-SP\SQLEXPRESS;Initial Catalog=UserDatabase;Integrated security=true");
        }
    }
   
}
