﻿using System;

namespace BattleOfRorke_sDrift
{
    public class Story
    {
        public void Intro()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The date is the 22nd of January 1879.");
            Console.ReadLine();
            Console.WriteLine("You are Lieutenant John Chard.");
            Console.ReadLine();
            Console.WriteLine("You command part of 5th Field Company of Royal Engineers.");
            Console.ReadLine();
            Console.WriteLine("You have about 150 men and a few of them are injured, and your mission was to build a bridge in Africa. ");
            Console.ReadLine();
            Console.WriteLine("That is until you hear news of a battle headed your way,The Zulu tribe is coming to attack. ");
            Console.ReadLine();
            Console.WriteLine("You must make a choice to leave take your men and leave or stay and fight.");
            Console.ReadLine();
            Console.WriteLine("Which do you choose?" );
            Console.ReadLine();
            Console.ResetColor();
        }

        public void Middle()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("You realize that you don't have a weapon. You order one of your soldiers " +
                "to bring you a few to choose from. He says: ");
           
            Console.ReadLine();
            Console.ResetColor();
        }

        public void End()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("There are thousands of men in the Zulu tribe. You and your men have been fighting for hours.");
            Console.ReadLine();
            Console.WriteLine("Your hospital was burned down in the choas. But somehow you are able to fight them off. ");
            Console.ReadLine();
            Console.WriteLine("Finally they attacks slow down, the morning comes.");
            Console.ReadLine();
            Console.WriteLine("the next morning, the Zulus approach to within several hundred yards and begin singing a war chant ");
            Console.ReadLine();
            Console.WriteLine("It was sung to honour the bravery of the British. And then the Zulu's left.");
            Console.ReadLine();
            Console.ResetColor();
        }
        public void Disclaimer()
        {
            Console.WriteLine("Disclaimer: This is loosely based on the move ZULU - 1964. Which was loosely based on the battle in 1879" +
                " Not all events are accurate.");
        }
    }

}
