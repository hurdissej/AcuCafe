using System.Collections.Generic;
using AcuCafe.Models;

namespace AcuCafe.Core.Repositories
{
    public interface IDrinksRepository
    {
        IEnumerable<Drinks> GetDrinks();
    }
}