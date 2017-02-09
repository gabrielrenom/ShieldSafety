using ShieldSafety.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShieldSafety.DAL.Configuration
{
    public class CustomerConfig:EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            //## Primary Key
            HasKey(t => t.Id);
        }
    }
}
