using System;
using NUnit.Framework;
using PaintPalleteProxy.Utils;

namespace PaintPalleteProxyTest
{
    [TestFixture]
    public class StringExtensionTest
    {
        [Test]
        public void CapitalFirstLetterTest()
        {
            //Arrange
            string myString = "test";
            string result = myString.CapitalFirstLetter();
            Assert.AreEqual('T', result[0]);
        }
    }
}
