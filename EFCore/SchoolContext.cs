using System;
using System.Collections.Generic;
using System.Text;
using DbModels.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        private string databasePath;

        public SchoolContext()
        {

        }


        public SchoolContext(string connString)
        {
            databasePath = connString;
            //Database.SetInitializer<SchoolContext>(null);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Filename={databasePath}");
        }
    }
}

