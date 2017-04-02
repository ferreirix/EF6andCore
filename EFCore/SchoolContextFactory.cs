using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFCore
{
    public class SchoolContextFactory : IDbContextFactory<SchoolContext>
    {

        public SchoolContext Create(DbContextFactoryOptions options)
        {
            return new EFCore.SchoolContext("Server=(localdb)\\mssqllocaldb;Database=EF6MVCCore;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
