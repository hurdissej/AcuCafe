using System.Collections.Generic;
using AcuCafe.Models;

namespace AcuCafe.Core.Repositories
{
    public interface IOptionsRepository
    {
        IEnumerable<Options> GetOptions();
    }
}