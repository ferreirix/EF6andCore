using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DbModels.Models;
//using EF6.Models;

namespace EF6
{
    #region snippet_Constructor
    public class SchoolContext : DbContext
    {
        public SchoolContext(string connString) : base(connString)
        {
            Database.SetInitializer<SchoolContext>(null);
        }
        #endregion

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}