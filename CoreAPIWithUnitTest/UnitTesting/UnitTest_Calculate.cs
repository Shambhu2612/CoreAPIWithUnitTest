using BusinessAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest_Calculate
    {
        [TestMethod]
        public void Addition()
        {
            //Arrange
            Calculate obj = new Calculate();
            int num1 = 10;
            int num2 = 5;
            int expected = 15;


            //Act
            int actual = obj.Addition(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sustraction()
        {
            //Arrange
            Calculate obj = new Calculate();
            int num1 = 10;
            int num2 = 5;
            int expected = 5;


            //Act
            int actual = obj.Substarction(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sustraction_2()
        {
            //Arrange
            Calculate obj = new Calculate();
            int num1 = 5;
            int num2 = 10;
            int expected = -1;


            //Act
            int actual = obj.Substarction(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiplication()
        {
            //Arrange
            Calculate obj = new Calculate();
            int num1 = 10;
            int num2 = 5;
            int expected = 50;


            //Act
            int actual = obj.Mulitplication(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Division()
        {
            //Arrange
            Calculate obj = new Calculate();
            int num1 = 26;
            int num2 = 5;
            int expected = 5;


            //Act
            int actual = obj.Dividion(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
