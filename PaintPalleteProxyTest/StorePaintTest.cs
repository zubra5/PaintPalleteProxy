using System;
using NUnit.Framework;
using PaintPalleteProxy;
using PaintPalleteProxy.Utils;

namespace PaintPalleteProxyTest
{
    [TestFixture]
    public class StorePaintTest
    {
        private StorePaint _paintPallete;

        [SetUp]
        public void SetUp()
        {
            _paintPallete = new StorePaint();
        }
            

        [Test]
        public void GetPaintEqualConsoleColorTest()
        {
            var paint=_paintPallete.GetPaint("blue");

            Assert.AreEqual(ConsoleColor.Blue, paint.Color);
        }

        [Test]
        public void GetPaintThrowUnknownColorException()
        {
            Assert.That(()=> _paintPallete.GetPaint("test"), Throws.TypeOf<UnknownColorException>());
        }

        [Test]
        public void NewPaintThrowUnknownColorException()
        {
            Assert.That(() => new Paint("test"), Throws.TypeOf<UnknownColorException>());
        }
    }
}
