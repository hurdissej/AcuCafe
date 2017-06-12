using AcuCafe.Models;

namespace AcuCafe.Core
{
    public interface IUnitOfWork
    {
        IDrinksRepository Drinks { get; set; }
        void Complete();
    }
}