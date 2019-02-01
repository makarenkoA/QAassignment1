using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QAassignment1;

namespace QAassignment1
{
    [TestFixture]
    class QAassignment1_tests
    {
      
        [Test]
        public void GetLength_input5_expectedLengthEquals5()
        {

            int length = 5;
            int width = 2;
            Rectangle testRectangle = new Rectangle(length, width);

            int testLength = testRectangle.GetLength();

            Assert.AreEqual(testLength, length);

        }

        [Test]
        public void GetWidth_input8_expectedWidthEquals8()
        {

            int length = 5;
            int width = 8;
            Rectangle testRectangle = new Rectangle(length, width);

            int testWidth = testRectangle.GetWidth();

            Assert.AreEqual(testWidth, width);

        }

        [Test]
        public void SetLength_input2_expectedLengthEquals2()
        {
            int length = 3;
            int width = 4;
            Rectangle testRectangle = new Rectangle(length, width);

            int testLength = 2;
            testRectangle.SetLength(testLength);

            Assert.AreEqual(testLength, testRectangle.GetLength());

        }

        [Test]
        public void SetWidth_input7_expectedWidthEquals7()
        {
            int length = 3;
            int width = 4;
            Rectangle testRectangle = new Rectangle(length, width);

            int testWidth = 7;
            testRectangle.SetWidth(testWidth);

            Assert.AreEqual(testWidth, testRectangle.GetWidth());

        }

        [Test]
        public void GetPerimeter_input2and5_expectedPerimeterEquals14()
        {
            int length = 2;
            int width = 5;
            Rectangle testRectangle = new Rectangle(length, width);

            int testPerimeter = 14;

            Assert.AreEqual(testPerimeter, testRectangle.GetPerimeter());

        }

        [Test]
        public void GetArea_input3and9_expectedAreaEquals27()
        {
            int length = 3;
            int width = 9;
            Rectangle testRectangle = new Rectangle(length, width);

            int testArea = 27;

            Assert.AreEqual(testArea, testRectangle.GetArea());

        }
    }
}
