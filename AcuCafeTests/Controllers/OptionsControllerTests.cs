using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http.Results;
using AcuCafe.Controllers.APIs;
using AcuCafe.Core;
using AcuCafe.Core.Repositories;
using AcuCafe.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AcuCafeTests.Controllers
{
    [TestClass]
    public class OptionsControllerTests
    {
        private OptionsController _controller;
        private Mock<IOptionsRepository> _repository;
        
        [TestInitialize]
        public void initialise()
        {
            _repository = new Mock<IOptionsRepository>();

            var mockUoW = new Mock<IUnitOfWork>();
            mockUoW.SetupGet(o => o.Options).Returns(_repository.Object);

            _controller = new OptionsController(mockUoW.Object);
        }

        [TestMethod]
        public void GetOptions_methodCalled_OptionsReturned()
        {
            var result = _controller.GetOptions();

            result.Should().BeOfType<OkNegotiatedContentResult<IEnumerable<Options>>>();
        }

    }
}
