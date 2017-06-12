using System;
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
    public class OptionsRepositoryTests
    {
        private OptionsRepository _repository;
        private Mock<DbSet<Options>> _mockOptions;

        [TestInitialize]
        public void initialise()
        {
            _mockOptions = new Mock<DbSet<Options>>();

            var mockContext = new Mock<IApplicationDbContext>();
            mockContext.SetupGet(o => o.Options).Returns(_mockOptions.Object);

            _repository = new OptionsRepository(mockContext.Object);
            
        }

        [TestMethod]
        public void GetOptions_MethodCalled_OptionsReturned()
        {
            var options  = new Options();

            _mockOptions.SetSource(new [] {options});

            var result = _repository.GetOptions();

            result.Should().Contain(options);
        }

    }
}
