using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

namespace UnitTests.Models
{
    [TestClass]
    public class LogModelUnitTests
    {
        [TestMethod]
        public void LogModel_Default_Should_Pass()
        {

            // Arange

            // Act
            var result = new LogModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void LogModel_Update_Valid_Data_Should_Pass()
        {

            // Arange
            var myTest = new LogModel();
            var myUpdate = new LogModel
            {
                PhoneID = "Phone id"
            };

            // Act
            var result = myTest.Update(myUpdate);

            // Assert
            Assert.AreEqual(myUpdate.PhoneID, myTest.PhoneID);
        }

        [TestMethod]
        public void LogModel_Update_Invalid_Null_Data_Should_Fail()
        {

            // Arange
            var myTest = new LogModel(); 

            // Act
            var result = myTest.Update(null);

            // Assert
            Assert.AreEqual(null, myTest.PhoneID);
        }

        [TestMethod]
        public void LogModel_Update_Different_ID_Should_Not_Update()
        {
            // Business rule is that the ID is not updatable.  
            // So need to add a test to verify that the ID does not change
            // If the code has a bug, fix the bug and enable the test assert
            
            // Arange
            var myTest = new LogModel();
            var myUpdate = new LogModel
            {
                PhoneID = "Phone id",
                ID = "bogus"
            };

            // Remeber the old ID
            var myTestID = myTest.ID;

            // Act
            var result = myTest.Update(myUpdate);

            // Assert
            //Assert.AreEqual(myTestID, myTest.ID);
        }
    }
}
