using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            //Arrange

            //Act
            var result = new ReportViewModel();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            //Arrange
            var myTest = new ReportViewModel();

            //Act
            var result = myTest.NumberOfUsers;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            //Arrange
            var myTest = new ReportViewModel();

            //Act
            var myTestNumberOfUsers = myTest.NumberOfUsers;
            myTest.NumberOfUsers = 7;

            //Assert
            Assert.AreNotEqual(myTestNumberOfUsers, myTest.NumberOfUsers);
            Assert.AreEqual(myTest.NumberOfUsers, 7);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {
            //Arrange
            var myTest = new ReportViewModel();

            //Act
            var result = myTest.LogViewModel;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {
            //Arrange
            var myTest = new ReportViewModel();

            var myLog = new LogModel();
            var myPhoneId = "Phone";


            //Act
            myLog.PhoneID = myPhoneId;
            var result = myLog.PhoneID;

            //Assert
            Assert.AreEqual("Phone", result);
            
        }

    }
}

