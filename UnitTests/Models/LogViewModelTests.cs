using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class LogViewModelTests
    {
        [TestMethod]
        public void LogViewModel_Instantiate_Default_Should_Pass()
        {
            //Arrange


            //Act
            var result = new LogViewModel();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogViewModel_Get_Default_Should_Pass()
        {
            //Arrange
            var myTest = new LogViewModel();

            //Act
            var result = myTest.LogList;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogViewModel_Set_Default_Should_Pass()
        {
            //Arrange
            var myTest = new LogViewModel();

            var myList = new List<LogModel>();
            myList.Add(new LogModel { PhoneID = "Phone" });

            //Act
            myTest.LogList = myList;
            var result = myTest.LogList;

            //Assert
            Assert.AreEqual("Phone", result[0].PhoneID);
        }
    }
}
