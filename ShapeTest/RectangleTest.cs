using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeTest
{
    public class RectangleTest
    {
        [TestMethod]
        public void GetAreaREC()
        {
            //Arrange
            double height = 5;
            double width = 4;
            Rectangle r = new Rectangle(height, width);
            //Act
            var resule = r.GetArea();
            //Assert
            Assert.AreEqual(20, resule.ToString());

        }
    }
}
