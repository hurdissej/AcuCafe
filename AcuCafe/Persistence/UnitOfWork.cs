using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcuCafe.Core;
using AcuCafe.Core.Repositories;
using AcuCafe.Models;
using AcuCafe.Repositories;

namespace AcuCafe.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext Context { get; set; }
        
        public IDrinksRepository Drinks { get; set; }
        public IOptionsRepository Options { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            Context = context;
            Drinks = new DrinksRepository(context);
            Options = new OptionsRepository(context);
        }

        public void Complete()
        {
            Context.SaveChanges();
        }
    }
}