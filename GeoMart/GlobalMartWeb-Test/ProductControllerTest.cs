using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GlobalMartWeb.Controllers;
using System.Web.Mvc;

namespace GlobalMartWeb_Test
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void GetProductListTest()
        {
            var controller = new ProductController();
            var result = controller.GetProductById(1) as ViewResult;
            Assert.AreEqual("ProductDetails", result.ViewName);
        }
    }
}
