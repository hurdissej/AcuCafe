using System.Collections.Generic;
using AcuCafe.Core.Folder;
using AcuCafe.Models;

namespace AcuCafe.Core.Repositories
{
    public interface IOrdersRepository
    {
        IEnumerable<Orders> GetOrders();
        IEnumerable<Orders> GetOrder(int id);
        void CreateOrder(OrderDTO order, IUnitOfWork unitOfWork);
        int GetOrderId();
        void DeleteOrder(int orderId);
    }
}