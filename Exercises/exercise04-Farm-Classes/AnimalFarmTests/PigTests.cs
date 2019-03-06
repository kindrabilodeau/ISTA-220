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
    public class PigTests
    {
        [TestMethod()]
        public void SpeakTest()
        {
            //arrange
            Pig P = new Pig("Gus");
            //act
            string talk = P.Speak();
            //assert
            Assert.AreEqual(talk, "Oink Oink I'm Pig!");
        }

        [TestMethod()]
        public void EatTest()
        {
            Pig P = new Pig("Gus");
            string roll = P.Play();
            Assert.AreEqual(roll, "I like to roll in the mud");
        }
    }
}