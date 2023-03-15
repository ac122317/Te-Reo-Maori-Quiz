﻿namespace Te_Reo_Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args) //Beginning of playing method.
        {
            playing();

            static void playing() //Beginning of playing Method.
            {
                String name, level;
                bool valid = false;

                Console.WriteLine("\t\t\tWelcome to my Te Reo Maori Quiz.\nThis is a multiple choice quiz with three different levels, Easy, Medium and Hard. Each level will have 10 different questions and for each correct question you will be awarded 1 point. Good luck!");

                Console.Write("\nPlease enter your name to begin: ");
                name = Console.ReadLine(); //I am welcoming the user to the quiz and asking for their name and assigning it to the name variable.

                Console.WriteLine("\nHello " + name + ", please choose your level: Easy, Medium or Hard (please type E for easy, M for Medium or H for Hard).");

                do
                {
                    level = Console.ReadLine().ToUpper(); //Asks user what level they would like to play and takes input from them to decide this.
                    if (level == "E")
                    {
                        Console.Clear();
                        level1();
                        valid = true;
                    }
                    else if (level == "M")
                    {
                        Console.Clear();
                        level2();
                        valid = true;
                    }
                    else if (level == "H")
                    {
                        Console.Clear();
                        level3();
                        valid = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid option: ");
                        valid = false;
                    }
                } while (valid != true);
            }
        } //End of playing method.

        static void level1()
        {
            Console.WriteLine("\nWelcome to the Easy level.");
        }
        static void level2()
        {
            Console.WriteLine("\nWelcome to the Medium level.");
        }
        static void level3()
        {
            Console.WriteLine("\nWelcome to the Hard level.");
        }
    } //End of main method.
}
