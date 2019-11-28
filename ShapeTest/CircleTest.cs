using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetArea_()
        {
            //Arrange
            double redius = 7;
            Circle c = new Circle(redius);
            //Act
            var result = c.GetArea();
            //Assert
            Assert.AreEqual("153.94", result.ToString("###,###.##"));

        }

        [TestMethod]
        public void GetAreaParimetor()
        {
            //Arrange
            double redius = 7;
            Circle c = new Circle(redius);
            //Act
            var result = c.GetArea();
            //Assert
            Assert.AreEqual("44", result.ToString("###,###.##"));

        }
    }
}
