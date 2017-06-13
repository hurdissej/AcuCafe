using AcuCafe.Core.Repositories;
using AcuCafe.Models;

namespace AcuCafe.Core
{
    public interface IUnitOfWork
    {
        IDrinksRepository Drinks { get; set; }
        IOptionsRepository Options { get; set; }
        IOrdersRepository Orders { get; set; }
        void Complete();
    }
}