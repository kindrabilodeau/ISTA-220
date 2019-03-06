using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalFarm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Tests
{
    [TestClass()]
    public class ChickenTests
    {
        [TestMethod()]
        public void SpeakTest()
        {
            //arrange
            Chicken C = new Chicken("Big Bird");
            //Act
            string talk = C.Speak();
            //assert
            Assert.AreEqual(talk, "Cluck Cluck, I'm a Chicken");
        }

        [TestMethod()]
        public void EatTest()
        {
            Chicken C = new Chicken("Big Bird");
            string food = C.Eat();
            Assert.AreEqual(food, "I eat veggies");
        }
    }
}