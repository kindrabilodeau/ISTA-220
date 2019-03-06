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
    public class DuckTests
    {
        [TestMethod()]
        public void SpeakTest()
        {
            //arrange
            Duck D = new Duck("Daffy");
            //act
            string talk = D.Speak();
            //arrange
            Assert.AreEqual(talk, "Quack Quack");
        }

        [TestMethod()]
        public void SplashTest()
        {
            Duck D = new Duck("Daffy");
            string play = D.Splash();
            Assert.AreEqual(play, "I like to play in the water ");
            Assert.AreEqual(play, "I like to play in the water ");
        }
    }
}