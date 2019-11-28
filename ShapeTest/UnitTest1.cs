using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLib;

namespace ShapeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Class1 c = new Class1();
            //Act
           int result = c.Add(1, 2);
            //Assert
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void Minus_Normal_IsZero() 
        {
            //Arrange
            Class1 c = new Class1();
            //Act
            int result = c.Minus(1, 1);
            //Assert
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void Multiply_Normal_Negative()
        {
            //Arrange
            Class1 c = new Class1();
            //Act
            int multi = 1;
            int power = -2;
            int result = c.Multiply(multi, power);
            //Assert
            Assert.AreEqual(-2, result);

        }
    }
}
