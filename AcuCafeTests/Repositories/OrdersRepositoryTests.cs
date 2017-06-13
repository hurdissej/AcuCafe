using System;
using System.Collections.Generic;
using System.Data.Entity;
using AcuCafe.Core.Repositories;
using AcuCafe.Models;
using AcuCafe.Repositories;
using AcuCafeTests.Extensions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AcuCafeTests.Repositories
{
    [TestClass]
    public class OrdersRepositoryTests
    {
        private OrdersRepository _repository;

        private Mock<DbSet<Orders>> _mockOrders;
        private Mock<DbSet<Drinks>> _mockDrinks;
        private Mock<DbSet<Options>> _mockOptions;

        [TestInitialize]
        public void initialise()
        {
            _mockOrders = new Mock<DbSet<Orders>>();
            _mockDrinks = new Mock<DbSet<Drinks>>();
            _mockOptions = new Mock<DbSet<Options>>();

            var mockContext = new Mock<IApplicationDbContext>();
            mockContext.SetupGet(o => o.Orders).Returns(_mockOrders.Object);

            _repository = new OrdersRepository(mockContext.Object);

        }

        [TestMethod]
        public void GetOrderId_OrderPlaced_MaxOrderNumberReturned()
        {
            var orders = new Orders(){OrderId = 1};

            _mockOrders.SetSource(new [] {orders});

            var result = _repository.GetOrderId();

            result.Should().Be(1);

        }
        
    }
}
