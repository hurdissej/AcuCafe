using System.Collections.Generic;
using AcuCafe.Models;

namespace AcuCafe.Core
{
    public interface IDrinksRepository
    {
        IEnumerable<Drinks> GetDrinks();
    }
}