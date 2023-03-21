using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;
namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            //sources
            int a = 3;
            int b = 5;
            int expected = 15;

            //executing
            Geometry rectangle = new Geometry();
            int actual = rectangle.RectangleS(a, b);

            //comparing
            Assert.AreEqual(expected, actual);
            //Assert.AreEqual using always in writing unit-tests
        }

        [TestMethod]
        public void CylinderV_2and4_50_24_returned()
        {
            //sources
            double radius = 2;
            double height = 4;
            double expected = 50.24;

            //executing
            Geometry cylinder = new Geometry();
            double actual = cylinder.CylinderV(radius, height);

            //comparing
            Assert.AreEqual(expected, actual);
        }
    }
}