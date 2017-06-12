using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcuCafe.Core;
using AcuCafe.Core.Repositories;
using AcuCafe.Models;

namespace AcuCafe.Repositories
{
    public class OptionsRepository : IOptionsRepository
    {
        private IApplicationDbContext _context;

        public OptionsRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Options> GetOptions()
        {
            var result = _context.Options
                            .ToList();

            return result;
        }


    }
}