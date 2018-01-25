using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class Program
    {
        public static int Choice { get; set; }
        //public static int Guess { get; set; }
        

        static void Main(string[] args)
        {
            GameTitle();

        }
        //METHOD
        public static void GameTitle()
        {
            Console.WriteLine("Hello. I hope you are doing well today.\n" +
                "I hear you are interested in taking part in the treasure hunt.");
            Console.WriteLine("Okay, you are ready to begin your quest.  Good\n" +
                "luck!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Choose which direction will start.");
            First();
        }

        //METHOD
        public static void First()
        {

            Console.WriteLine("1. You may choose to head west and follow the setting sun. ");
            Console.WriteLine("2. You may choose to meander south but be warned it may get\n" +
                        "extremely hot");
            Console.WriteLine("3. You may choose to take the road east, away from the \n" +
                        "setting sun and in to the oncoming darkness.");
            Console.WriteLine("4. Or you may choose to venture north. A very unpredictable \n" +
                        "path; not for the faint of heart.");
            Console.WriteLine("narrative welcome");
            Console.WriteLine("Please select your direction");
            Console.Write("Choice: ");
            Console.ReadLine().ToLower();
            Console.Clear();
         
        //SWITCH
            switch (Choice)
            {
                case 1:


                    {
                        Console.WriteLine("Ah, you have chosen to begin your adventure \n" +
                            "the north.");
                        Console.WriteLine("Are you sure you want to head north? You are wearing shorts \n" +
                            "t-shirt.");
                        Console.WriteLine("I know it the tempature is warm now, but it can get \n" +
                            "very, very...um, I don't want to concern you. Never mind. Go on. Be on your way.");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.WriteLine("Not five seconds later, you run into a fire breathing dragon and are roasted.");
                        GameOver();
                        break;

                    }
                case 2:
                
                    {
                        Console.WriteLine("The south. Here is sunblock and a hat. Watch out \n" +
                            "for the ...oh, wait, I shouldn't say anything about that, you may \n" +
                            "even encounter the salivating creature.  Oops, that slipped out.  \n" +
                            "You'll be fine. Go on. Run along.");
                        Console.WriteLine("Press enter to continue");
                        Second();
                        break;
                    }

                case 3:
                
                    {
                        Console.WriteLine("Are you sure you want to head to the east?\n" +
                            "Well, if you are sure. I don't have any advice for you so be\n" +
                            "on your way! Oh, do you have a flashlight on you. It gets very dark.");
                        Console.WriteLine("Good Luck!");
                        Second();
                        break;
                    }



                default:
                    {

                        Console.WriteLine("Which direction?  There are only 3 choices.\n" +
                            "Try again. Press Enter to choose which direction to go.");
                        First();
                        break;
                    }


            }




        }

        //METHOD
        public static void Second()
        {

            Random rnd = new Random();

            string[] secOptions = {"You start on your way and quickly\n" +
            "encounter a adorable gnome. ",
            "You start on your way and quickly encounter a small child.",
            "You start on your way and quickly encounter a slimey, snarling monster."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Do you turn and run away; Yes or no?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();
            
        //LOOP
            if (secChoice == "yes" || secChoice == "y")
            {
                Third();

            }
            else if (secChoice == "no" || secChoice == "n")
            {

                Console.WriteLine("You have chosen to run away. Whimp.  I am disappointed \n" +
                    "in you.  Come back when you have found your courage.");

                Console.ReadLine();
                GameOver();

            }
            else
            {
                Console.WriteLine("You have chosen to stay.  They have a question for you. \n" +
                    "Press Enter to continue.");
                Console.ReadLine();
                Second();

            }

        }
        //METHOD
        public static void Third()
        {
            int Guess = 0;

            Console.WriteLine("To continue on, you must you quess the magic number.");
            Console.WriteLine("Please guess a number between 0 and 50.");
            Console.Write("Guess:  ");
            Guess = Int32.Parse(Console.ReadLine());

        //CONDITIONAL
            while (Guess < 30)
            {
                Console.WriteLine("Nope, guess again");
                Console.Write("Guess: ");
                int.Parse(Console.ReadLine());
            }

        


        Console.WriteLine("Drat! You guessed!");
                Console.ReadLine();
        }

 

        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine("I'm sorry you may not play again.");
            Console.WriteLine("Good bye. Enjoy your day.");
            Console.ReadLine();
            Console.Clear();
            GameTitle();
        }

        public static void YouWin()
        {
            Console.Clear();
            Console.WriteLine("You have gotten passed the obstacle and reached the \n" +
                "treasure: a package of frozen grapes. Yummy! Enjoy!");
            Console.WriteLine("You are not my hero, but I'm sure you are someone's hero!");
            Console.ReadLine();
            Console.Clear();
            GameTitle();

        }

    
    }  
} 


           
   

