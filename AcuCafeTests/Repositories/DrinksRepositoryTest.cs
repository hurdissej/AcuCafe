using System.Collections.Generic;
using System.Data.Entity;
using AcuCafe.Models;
using AcuCafe.Repositories;
using AcuCafeTests.Extensions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AcuCafeTests.Repositories
{
    [TestClass]
    public class DrinksRepositoryTest
    {

        private DrinksRepository _repository;
        private Mock<DbSet<Drinks>> _mockDrinks;

        [TestInitialize]
        public void initalise()
        {
            _mockDrinks = new Mock<DbSet<Drinks>>();

            var mockContext = new Mock<IApplicationDbContext>();
            mockContext.SetupGet(d => d.Drinks).Returns(_mockDrinks.Object);

            _repository = new DrinksRepository(mockContext.Object);
        }

        [TestMethod]
        public void GetDrinks_NoDrinksAvailable_NothingReturned()
        {
            var drinks = new Drinks();

            _mockDrinks.SetSource(new [] {drinks});
            
            var result = _repository.GetDrinks();

            result.Should().Contain(drinks);
        }
    }
}
