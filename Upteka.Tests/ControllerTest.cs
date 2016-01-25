using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Upteka.BLL.DTOObjects;
using Upteka.BLL.Services.Concrete;
using Upteka.BLL.Services.Interfaces;
using Upteka.Controllers;

namespace Upteka.Tests
{
    [TestClass]
    public class ControllerTest
    {
        public Mock<IProductService> ServiceMock;

        public ProductController ProductController;

        [TestInitialize]
        public void Init()
        {
            ServiceMock = new Mock<IProductService>();

            ProductController = new ProductController(ServiceMock.Object);
        }


        [TestMethod]
        public void IndexViewTest()
        {
            var expected = new List<ProductDTO>() { new ProductDTO()};
            ServiceMock.Setup(it => it.GetAll()).Returns(expected);

            var result = ProductController.Index();

            var model = (result as ViewResult).Model as List<ProductDTO>;

            Assert.AreEqual(expected, model);
        }

        public void DetailsTest()
        {
            var expected = new ProductDTO
            {
                BarCode = "11215156",
                InStock = 21,
                Name = "Аспирин",
                Id = 1
            };
            ServiceMock.Setup(it => it.Find(1)).Returns(expected);

            var result = ProductController.Details(1);

            var model = (result as ViewResult).Model as ProductDTO;

            Assert.AreEqual(expected, model);
        }
    }
}
