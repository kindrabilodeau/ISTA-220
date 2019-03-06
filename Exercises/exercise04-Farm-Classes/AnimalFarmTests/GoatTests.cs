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
    public class GoatTests
    {
        [TestMethod()]
        public void EatTest()
        {
            //arrange 
            Goat G = new Goat("Henry");
            //act 
            string snacks = G.Eat();
            //assert 
            Assert.AreEqual(snacks, "Snackkks!!");  //this take two parameters 
        }

        [TestMethod()]
        public void SpeakTest()
        {
            //arrane
            Goat G = new Goat("Hilda");
            //act
            string talk = G.Speak();
            //assert 
            Assert.AreEqual(talk, "I am Goat. Hear me Bahh");
        }
    }
}
