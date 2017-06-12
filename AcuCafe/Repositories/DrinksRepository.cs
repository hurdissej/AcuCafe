using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcuCafe.Core;
using AcuCafe.Core.Repositories;
using AcuCafe.Models;

namespace AcuCafe.Repositories
{
    public class DrinksRepository : IDrinksRepository
    {
        private readonly IApplicationDbContext _context;

        public DrinksRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Drinks> GetDrinks()
        {
            return _context.Drinks
              .ToList();
        }
    
    }
}