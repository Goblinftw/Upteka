using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Upteka.BLL.DTOObjects;
using Upteka.BLL.Services.Concrete;
using Upteka.DAL.Entity;

namespace Upteka.Tests
{
    [TestClass]
    public class ServiceTest
    {
        public ServiceTest()
        {
            BLL.Infrastructure.AutomapperInit.Load();
        }

        [TestMethod]
        public void CreateProduct()
        {
            var mockSet = new Mock<DbSet<Product>>();

            var mockContext = new Mock<DAL.IDbContext>();
            mockContext.Setup(m => m.Set<Product>()).Returns(mockSet.Object);

            var service = new ProductService(mockContext.Object);
            var product = new ProductDTO
            {
                BarCode = "11215156",
                InStock = 21,
                Name = "Аспирин"
            };
            service.Add(product);

            mockSet.Verify(m => m.Add(It.IsAny<Product>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void DeleteProduct()
        {
            var data = new List<Product>
            {
                new Product {Name = "BBB", BarCode = "112115", InStock = 15, Id = 1},
                new Product {Name = "ZZZ", BarCode = "112116", InStock = 23, Id = 2},
                new Product {Name = "AAA", BarCode = "112116", InStock = 30, Id = 3}
            };

            var mockSet = new Mock<DbSet<Product>>()
                .SetupData(data, objects => data.SingleOrDefault(d => d.Id == (int)objects.First()));
            

            var mockContext = new Mock<DAL.IDbContext>();
            mockContext.Setup(m => m.Set<Product>()).Returns(mockSet.Object);
            var service = new ProductService(mockContext.Object);

            service.Delete(1);
            Assert.IsNull(data.Find(x => x.Id == 1));
        }

        [TestMethod]
        public void ListProducts()
        {
            var data = new List<Product>
            {
                new Product {Name = "BBB", BarCode = "112115", InStock = 15, Id = 1},
                new Product {Name = "ZZZ", BarCode = "112116", InStock = 23, Id = 2},
                new Product {Name = "AAA", BarCode = "112117", InStock = 30, Id = 3}
            };

            var mockSet = new Mock<DbSet<Product>>()
                .SetupData(data);


            var mockContext = new Mock<DAL.IDbContext>();
            mockContext.Setup(m => m.Set<Product>()).Returns(mockSet.Object);
            var service = new ProductService(mockContext.Object);

            var result = service.GetAll().ToList();


            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("112115", result[0].BarCode);
            Assert.AreEqual("112116", result[1].BarCode);
            Assert.AreEqual("112117", result[2].BarCode);
        }
    }
}
