using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarQube.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarQube.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void HesaplaTest()
        {
            //Arrange
            SonarQube.Controllers.HomeController. hesap = new SonarQube.Controllers.HomeController();

            //Act
            int sonuc = hesap.topla(20, 10);

            //Assert
            Assert.AreEqual(30, sonuc);
        }
    }
}