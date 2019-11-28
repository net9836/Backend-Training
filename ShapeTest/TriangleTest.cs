using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetArea()
        {
            //Arrange
            double height = 5;
            double width = 4;
            Triangle t = new Triangle(height,width);
            //Act
            var resule = t.GetArea();
            //Assert
            Assert.AreEqual(10, resule.ToString());

        }

    }
}
