using System;
using System.Data.Entity;

namespace ShieldSafety.DAL
{
    public  class SsInitialiser : DropCreateDatabaseIfModelChanges<SsContext>
    {
      
    }
}