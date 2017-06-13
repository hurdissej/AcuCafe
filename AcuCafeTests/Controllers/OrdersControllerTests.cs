using System;
using System.Collections.Generic;
using System.Web.Http.Results;
using AcuCafe.Controllers.APIs;
using AcuCafe.Core;
using AcuCafe.Core.Repositories;
using AcuCafe.Models;
using AcuCafe.Repositories;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AcuCafeTests.Controllers
{
    [TestClass]
    public class OrdersControllerTests
    {
        private Mock<IOrdersRepository> _repository;
        private OrdersController _controller;


        [TestInitialize]
        public void intialize()
        {
            _repository = new Mock<IOrdersRepository>();

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.SetupGet(o => o.Orders).Returns(_repository.Object);

            _controller = new OrdersController(mockUoW.Object);

        }

        [TestMethod]
        public void GetOrders_MethodCalled_ListReturned()
        {
            var result = _controller.GetOrders();

            result.Should().BeOfType<OkNegotiatedContentResult<IEnumerable<Orders>>>();

        }

        [TestMethod]
        public void DeleteOrder_OrderIdNotFound_BadRequest()
        {
            var result = _controller.DeleteOrder(123);

            result.Should().BeOfType<BadRequestErrorMessageResult>();
        }

        [TestMethod]
        public void DeleteOrder_OrderIdFound_OkResult()
        {
            var order = new Orders(){OrderId = 1};

            _repository.Setup(r => r.GetOrder(1)).Returns(new []{order});

            var result = _controller.DeleteOrder(1);

            result.Should().BeOfType<OkResult>();

        }
    }
}
