using System.Data.Entity;

namespace AcuCafe.Models
{
    public interface IApplicationDbContext
    {
        DbSet<Drinks> Drinks { get; set; }
        DbSet<Options> Options { get; set; }
    }
}