using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Tests
{
    [TestClass()]
    public class PointTests
    {
        [TestMethod()]
        public void DistanceToTest()
        {
            //Arrange
            Point a = new Point(0, 0);
            Point b = new Point(3, 4);
            //act 
            double h = a.DistanceTo(b);
            //Assert
            Assert.AreEqual(h, 5);
        }
    }
}