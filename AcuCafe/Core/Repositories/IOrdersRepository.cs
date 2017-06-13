using System.Collections.Generic;
using AcuCafe.Models;

namespace AcuCafe.Core.Repositories
{
    public interface IOrdersRepository
    {
        IEnumerable<Orders> GetOrders();
        void CreateOrder(Orders order);
        int GetOrderId();
    }
}