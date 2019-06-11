using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

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
    }
}
