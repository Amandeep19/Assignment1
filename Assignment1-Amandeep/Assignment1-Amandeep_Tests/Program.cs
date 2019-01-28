using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_Amandeep;
using NUnit.Framework;

namespace Assignment1_Amandeep_Tests
{
    [TestFixture]
    public class assignment1_Tests
    {
        [Test]
        public void GetLength_input1_expectLengthEquals1()
        {
            //arrange
            int l = 1;
            int w = 3;
            Rectangle testRectangle = new Rectangle(l, w);//expected length

            //act
            int length = testRectangle.GetLength();

            //assert
            Assert.AreEqual(length, l);
        }
        [Test]
        public void GetWidth_input1_expectWidthEquals1()
        {
            //arrange
            int l = 1;
            int w = 2;
            Rectangle testRectangle = new Rectangle(l, w);

            //act
            int width = testRectangle.GetWidth();

            //assert
            Assert.AreEqual(width, w);
        }
        [Test]
        public void SetWidth_input1_expectWidthEquals1()
        {
            //arrange
            int l = 1;
            int w = 1;
            Rectangle testRectangle = new Rectangle(l, w);

            //act
            int width = testRectangle.SetWidth(w);

            //assert
            Assert.AreEqual(width, w);
        }
        [Test]
        public void SetLenght_input1_expectLengthEquals1()
        {
            //arrange
            int l = 1;
            int w = 1;
            Rectangle testRectangle = new Rectangle(l, w);

            //act
            int length = testRectangle.SetLength(l);

            //assert
            Assert.AreEqual(length, l);
        }
        [Test]
        public void GetPerimeter_input2_expectWidthEquals8()
        {
            //arrange
            int l = 2;
            int w = 2;
            int p = 8;
            Rectangle testRectangle = new Rectangle(l, w);

            //act
            int perimeter = testRectangle.GetPerimeter();

            //assert
            Assert.AreEqual(perimeter, p);
        }
        [Test]
        public void GetArea_input2_expectWidthEquals4()
        {
            //arrange
            int l = 2;
            int w = 2;
            int a = 4;
            Rectangle testRectangle = new Rectangle(l, w);

            //act
            int area = testRectangle.GetArea();

            //assert
            Assert.AreEqual(area, actual: a);
        }
    }
}
