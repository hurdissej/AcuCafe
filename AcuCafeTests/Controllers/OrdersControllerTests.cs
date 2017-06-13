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
    }
}
