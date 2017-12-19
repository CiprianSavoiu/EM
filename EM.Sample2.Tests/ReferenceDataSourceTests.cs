using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample2.Demo3;
using Sample2.Demo3.Impl;

namespace EM.Sample2.Tests
{
    [TestClass]
    public class ReferenceDataSourceTests
    {
        [TestMethod]
        public void GetItems()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
        }

        [TestMethod]
        public void GetItemsByCode_Sql()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());

        }


        [TestMethod]
        public void GetItemsByCode_Xml()
        {
            var source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());

        }

    }
}
