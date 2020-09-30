using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPS.RestLayer;
using System;
using System.Collections.Generic;
using System.Text;
using UPS.Models;

namespace UPS.RestLayer.Tests
{
    [TestClass()]
    public class EmployeeServiceTests
    {
        [TestMethod()]
        public void GetEmployeeByNameTest()
        {
            //Arrange
            string arrangeName = "Kumar";
            string arrangeResponseCode = "200";

            //Act
            string actResponseCode = EmployeeService.GetEmployeeByName(arrangeName).Code.ToString();

            //Assert
            Assert.AreEqual(arrangeResponseCode, actResponseCode);
        }

        [TestMethod()]
        public void GetEmployeeByIdTest()
        {
            //Arrange
            int arrangeId = 250;
            string arrangeResponseCode = "200";

            //Act
            string actResponseCode = EmployeeService.GetEmployeeById(arrangeId).Code.ToString();

            //Assert
            Assert.AreEqual(arrangeResponseCode, actResponseCode);
        }

        [TestMethod()]
        public void CreateEmployeeTest()
        {
            //Arrange
            Employee employee = new Employee()
            {
                Name = "UPS",
                Email = "ups@ups.com",
                Gender = "Male",
                Status = "Active"
            };
            string arrangeResponseCodeDetail = "A resource was successfully created in response to a POST request. The Location header contains the URL pointing to the newly created resource.";

            //Act 
            string actResponseCodeDetail = EmployeeService.CreateEmployee(employee).ToString();

            //Assert
            Assert.AreEqual(arrangeResponseCodeDetail, actResponseCodeDetail);
        } 
    }
}