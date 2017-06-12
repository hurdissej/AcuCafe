using System;
using System.Collections.Generic;
using System.Web.Http.Results;
using AcuCafe.Controllers.APIs;
using AcuCafe.Core;
using AcuCafe.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AcuCafeTests.Controllers
{
    [TestClass]
    public class DrinksControllerTests
    {
        private DrinksController _controller;
        private Mock<IDrinksRepository> _mockRepository;

        [TestInitialize]
        public void initialise()
        {
            _mockRepository = new Mock<IDrinksRepository>();

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.SetupGet(d => d.Drinks).Returns(_mockRepository.Object);

            _controller = new DrinksController(mockUoW.Object);
        }

        [TestMethod]
        public void GetDrinks_MethodCalled_DrinksReturned()
        {
            var result = _controller.GetDrinks();

            result.Should().BeOfType<OkNegotiatedContentResult<IEnumerable<Drinks>>>();
        }
    }
}
