using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample1.Demo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1.Demo1.Tests
{
    [TestClass()]
    public class LegacyExternsionsTests
    {
        [TestMethod()]
        public void ToLegacyFormatTest_C20()
        {
            //Arrange
            var dateTime = new DateTime(1920, 12, 31);
            var expectedOut = "0201231";
            //Act
            var actualOut = dateTime.ToLegacyFormat();
            //Assert
            Assert.AreEqual(expectedOut, actualOut);
        }

        [TestMethod()]
        public void ToLegacyFormatTest_C21()
        {
            //Arrange
            var dateTime = new DateTime(2013, 10, 31);
            var expectedOut = "1131031";
            //Act
            var actualOut = dateTime.ToLegacyFormat();
            //Assert
            Assert.AreEqual(expectedOut, actualOut);
        }

        [TestMethod()]
        public void ToLegacyName()
        {
            //Arrange
            var name = "Ciprian Savoiu";
            var expectedOut = "SAVOIU, CIPRIAN";
            //Act
            var actualOut = name.ToLegacyFormat();
            //Assert
            Assert.AreEqual(expectedOut, actualOut);
        }
    }
}