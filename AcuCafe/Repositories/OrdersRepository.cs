using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AcuCafe.Core;
using AcuCafe.Core.Folder;
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

        public IEnumerable<Orders> GetOrder(int orderId)
        {
            return _context.Orders.Where(x => x.OrderId == orderId).ToList(); 
        }

        //ID Provider
        public int GetOrderId()
        {
            var id = _context.Orders.Max(i => i.OrderId);

            return id;
        }

        public void CreateOrder(OrderDTO order, IUnitOfWork _unitOfWork)
        {

            var id = _unitOfWork.Orders.GetOrderId() + 1;

            foreach (var drink in order.DrinkIds)
            {
                var newOrder = new Orders()
                {
                    OrderId = id,
                    DrinksId = drink,
                    OptionsId = null,
                    DateTime = DateTime.Now
                    

                };

                _context.Orders.Add(newOrder);
            }

            foreach (var option in order.OptionIds)
            {
                var newOrder = new Orders()
                {
                    OrderId = id,
                    DrinksId = null,
                    OptionsId = option,
                    DateTime = DateTime.Now

                };

                _context.Orders.Add(newOrder);
            }

        }

        public void DeleteOrder(int orderId)
        {
            var IdsToDelete = _context.Orders.Where(x => x.OrderId == orderId);

            foreach (var id in IdsToDelete)
            {
                _context.Orders.Remove(id);

            }

        }

    }
}