using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AcuCafe.Core.Repositories;
using AcuCafe.Models;

namespace AcuCafe.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private IApplicationDbContext _context;

        public OrdersRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Orders> GetOrders()
        {
            return _context.Orders
                .Include(o => o.Drinks)
                .Include(d => d.Options)
                .ToList();
        }

        public int GetOrderId()
        {
            var id = _context.Orders.Max(i => i.OrderId);

            return id;
        }

        public void CreateOrder(Orders order)
        {
            _context.Orders.Add(order);
        }

    }
}