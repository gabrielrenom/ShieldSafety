using System;
using System.Data.Entity;

namespace ShieldSafety.DAL
{
    internal class SsInitialiser : IDatabaseInitializer<SsContext>
    {
        public void InitializeDatabase(SsContext context)
        {
            throw new NotImplementedException();
        }
    }
}