using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is my Super Neat Animal Farm");
            Console.WriteLine("These are my Animals");
            Console.ReadLine();
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("These are my Horse's");
            Console.ResetColor();
            makeHorse("Tater Trot", "Everyone loves to come over because of my incredible... Horse-pitality.");
            makeHorse("Al Capony", "Excuse me I'm not sick, just a little..Horse");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Meet The Goats");
            Console.ResetColor();
            makeGoat("Tippy", "If a goat grows a beard, is it a goatee?");
            makeGoat("Bill Nye the Goat Guy", "If a young goat learns martial arts, are they a karate kid?");
            makeGoat("Goatzilla", "My favorite drink? Goat - arade.");
            makeGoat("Vincent van Goat", "Cat goat your tongue?");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("This is my Donkey");
            Console.ResetColor();
            makeDonkey("barthou-mule", "How do Mules unlock the barn?", "With Don-Keys");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Meet The Pigs");
            Console.ResetColor();
            makePig("Squiggley The Piggly", "If pigs learned to fly, would the price of bacon skyrocket?");
            makePig("Piggie Smalls", "If pigs learned karate, their favorite move would be the Pork-Chop");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Meet The Chickens");
            Console.ResetColor();
            makeChicken("Albert Eggstein", "What do you get when you cross a ghost with a chicken?", "A poultry-geist.");
            makeChicken("Attila the Hen", "Why did I go to KFC?", "I wanted to see a chicken strip.");
            makeChicken("Cluck Norris", "What happens when a hen eats gunpowder?", "She lays hand gren-eggs.");
            makeChicken("Hen Solo", "Why does a chicken coop have two doors?", "Because if had four doors it would be a chicken sedan.");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Meet The Ducks");
            Console.ResetColor();
            makeDuck("Quackie Chan", "Why did the neighbors get mad me? Because I was a Peeking-Duck.");
            makeDuck("Quack Sparrow", "Release the Quacken!!!");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("These are my Alpacas");
            Console.ResetColor();
            makeAlpaca("Chewpacaa", "The end is near, the Alpacalypse is coming");
            makeAlpaca("Alpac-aMan", "Don't fight me, Alpaca Punch");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Thanks for checking out my Farm!");
            Console.ResetColor();
        }

        private static void makeDonkey(string newDonkey, string Question, string Answer)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"My name is {newDonkey} and I am a Donkey");
            Console.WriteLine($"{newDonkey} says:{Question}");
            Console.WriteLine($"{Answer}");
            Console.ResetColor();
            Console.ReadLine();
        }

        private static void makeAlpaca(string newAlpaca, string pun)
        {
            Alpaca A = new Alpaca(newAlpaca);
            string talk = A.Speak();
            Console.WriteLine($"My name is {newAlpaca} and I say {talk}");
            Console.WriteLine($"{newAlpaca} says {pun}");
            Console.ResetColor();
            Console.ReadLine();
        }

        private static void makeHorse(string newHorse, string pun)
        {
            Horse H = new Horse(newHorse);
            string talk = H.Speak();
            Console.WriteLine($"{newHorse} says: {talk}");
            Console.WriteLine($"{newHorse} says: {pun}");
            Console.ResetColor();
            Console.ReadLine();
        }

        private static void makeDuck(string newDuck, string Pun)
        {
            Duck D = new Duck(newDuck);
            string talk = D.Speak();
            string play = D.Splash();
            Console.WriteLine($"{newDuck} says: {talk} and {play}");
            Console.WriteLine($"{newDuck} says: {Pun}");
            Console.ResetColor();
            Console.ReadLine();
        }

        private static void makeChicken(string newChicken, string pun, string joke)
        {
            Chicken C = new Chicken(newChicken);
            string talk = C.Speak();
            string food = C.Eat();
            Console.WriteLine($"{newChicken} says: {talk}, and {food}");
            Console.WriteLine($"{newChicken} says: {pun}");
            Console.WriteLine($"{joke}");
            Console.ResetColor();
            Console.ReadLine();
        }

        private static void makePig(string newPig, string Pun)
        {
            Pig P = new Pig(newPig);
            string talk = P.Speak();
            string roll = P.Play();
            Console.WriteLine($"{newPig} says: {talk}, and {roll}");
            Console.WriteLine($"{newPig} says: {Pun}");
            Console.ResetColor();
            Console.ReadLine();
        }

        private static void makeGoat(string newGoat, string Pun)
        {

            Goat G = new Goat(newGoat);
            string talk = G.Speak();
            string food = G.Eat();
            Console.WriteLine($"{newGoat} says: {talk} and I like {food}");
            Console.WriteLine($"{newGoat} says: {Pun}");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}