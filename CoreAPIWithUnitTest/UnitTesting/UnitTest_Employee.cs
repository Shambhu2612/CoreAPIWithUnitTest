using BusinessAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest_Employee
    {
        [TestMethod]
        public void Employees()
        {
            //Arrange
            Employee employee = new Employee();
            int id = 101;
            string expected = "Sam";

            //Act
            string actual = employee.GetEmployees(id);


            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Employees_2()
        {
            //Arrange
            Employee employee = new Employee();
            int id = 104;
            string expected = "";

            //Act
            string actual = employee.GetEmployees(id);


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
