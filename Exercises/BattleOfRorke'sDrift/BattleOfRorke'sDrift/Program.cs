using System;

namespace BattleOfRorke_sDrift
{
    class Program
    {
        static void Main(string[] args)
        {
            Story part1 = new Story();
            part1.Intro();
            Console.WriteLine("Choose 1 to leave. Choose 2 to stay");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            { Console.WriteLine("You and your men leave, but the injured men slow you down. The Zulu tribe finds you " +
                    "and you die.");
               System.Environment.Exit(0);
            }
            else
                Console.WriteLine("Now that you've decided to stay you must build up the defenses");

            British B = new British();
            Officer John = new Officer();
            Console.WriteLine("You give the order:");
            Console.WriteLine();
            John.Orders("Men! Build a wall around us!");
            Enlisted E = new Enlisted();
            E.Brit(); 
            E.Reports();

            Console.WriteLine("Your men built up the defense just in time because you see off in the distance, the chief..");
            Console.ReadLine(); 
            Chief C = new Chief();
            Warrior W = new Warrior();
            Spear stick = new Spear();
            Shield newsheild = new Shield();
            C.Point("The cheif points in your direction");
            Console.WriteLine();

            Songs singing = new Songs();
            ZuluSong zuSong = new ZuluSong();
            BritSong brisong = new BritSong();

            singing.Sing(); 
            zuSong.Zsong();
            brisong.Sing(); 
            brisong.Bsong();
         

            Console.WriteLine($" The Cheif:");
            C.Yell();
            W.Run();
            W.Yell();
            Console.WriteLine("The warriors will be here soon, they run fast. With them they have weapons");
            stick.Stab();
            newsheild.Defense();
            newsheild.Sheild();

            Story Part2 = new Story();
            Part2.Middle();
            Weapons arms = new Weapons();
            Sword S = new Sword();
            Rifle R = new Rifle();
            Pistol P = new Pistol();
            S.Defense();
            S.Looks();
            R.Defense();
            R.Shoots();
            P.Defense();
            P.handgun();

            Choose();

            Console.WriteLine("You then start to give commands to your men");
            John.Orders("Front Rank. Fire!");
            John.Orders("Back Rank. Fire!");

            Story part3 = new Story();
            part3.End();

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("THE END");
            zuSong.Disclaimer();
            part3.Disclaimer(); 

        }

        private static void Choose()
        {
            Console.WriteLine("Choose 1 for a sword. Choose 2 for a rifle. Choose 3 for a pistol");
            int choice2 = int.Parse(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    Console.WriteLine("You choose a sword... Looks really cool but you may want to pick something else...");
                    break;
                case 2:
                    Console.WriteLine("You chose a rifle, good choice but not it's not a weapon that an officer should carry");
                    break;
                case 3:
                    Console.WriteLine("Good Choice! A pistol is the weapon an officer should carry!");
                    break;
                    }
                    Console.WriteLine("Choose Another? 1 for Yes or 2 for No");
                    int tryagain = int.Parse(Console.ReadLine());
                    switch (tryagain)
                    {
                        case 1:
                            Choose();
                            break;
                        case 2:
                            Console.WriteLine("Okay:");
                            break;
                    }
            }
        }
    }

