using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AcuCafe.Core;
using AcuCafe.Core.Folder;
using AcuCafe.Models;

namespace AcuCafe.Controllers.APIs
{
    public class OrdersController : ApiController
    {
        private IUnitOfWork _unitOfWork;

        public OrdersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //Get /api/orders
        public IHttpActionResult GetOrders()
        {
            var result = _unitOfWork.Orders.GetOrders();

            return Ok(result);
        }

        [HttpPost]
        public void PostOrder(OrderDTO order)
        {
            _unitOfWork.Orders.CreateOrder(order, _unitOfWork);
        }
    }
}
