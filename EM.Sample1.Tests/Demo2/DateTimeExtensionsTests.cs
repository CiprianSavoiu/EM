using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Sample1.Demo2;

namespace Sample1.Demo2.Tests
{
    [TestClass()]
    public class DateTimeExtensionsTests
    {
        [TestMethod()]
        public void ToXmlDateTimeTest()
        {
            //Arrange
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            var expectedOut = "2013-10-24T13:10:15.951Z";
            //Act
            var actualOut = dateTime.ToXmlDateTime();
            //Assert
            Assert.AreEqual(expectedOut, actualOut);
        }

        [TestMethod()]
        public void ToXmlDateTimeTest_local()
        {
            //Arrange
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            var expectedOut = "2013-10-24T13:10:15.951+01:00";
            //Act
            var actualOut = dateTime.ToXmlDateTime(XmlDateTimeSerializationMode.Local);
            var actualOut2 = DateTimeExtensions.ToXmlDateTime(dateTime, XmlDateTimeSerializationMode.Local);
            //Assert
            Assert.AreEqual(expectedOut, actualOut);
            Assert.AreEqual(expectedOut, actualOut2);
        }
    }
}