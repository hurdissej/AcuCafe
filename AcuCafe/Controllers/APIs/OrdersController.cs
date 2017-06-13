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
            _unitOfWork.Complete();
        }


        // Delete /api/id
        [HttpDelete]
        public IHttpActionResult DeleteOrder(int Id)
        {
            if (_unitOfWork.Orders.GetOrder(Id) == null)
            {
                return BadRequest("Order Id Not Found");
            }

            _unitOfWork.Orders.DeleteOrder(Id);
            _unitOfWork.Complete();

            return Ok();
        }
    }
}
