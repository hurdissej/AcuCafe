using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AcuCafe.Models
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Drinks> Drinks { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public ApplicationDbContext()
            : base("ApplcationDbContext")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}