using ShieldSafety.DAL.Configuration;
using ShieldSafety.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShieldSafety.DAL
{
    public class SsContext : DbContext
    {
        public SsContext() : base("SsContext")
        {

        }

        static SsContext()
        {
            Database.SetInitializer<SsContext>(new SsInitialiser());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CustomerConfig());
        }

        public DbSet<Customer> Attractions { get; set; }

    }

}
