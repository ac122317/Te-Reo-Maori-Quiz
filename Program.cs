namespace Te_Reo_Maori_Quiz
{
    internal class Program
    {
        static int points = 0;//Rather than creating an integer called points in the playing method I decided to create it inside the class Program, therefore I don't have to create parameters and reference points inside of the level methods.
        static void Main(string[] args) //Beginning of main method.
        {
            playing();

            static void playing() //Beginning of playing Method.
            {
                String playerName, selectedLevel;
                bool valid = false;
                

                Console.WriteLine("\t\t\tWelcome to my Te Reo Maori Quiz.\nThis is a multiple choice quiz with three different levels, Easy, Medium and Hard. Each level will have 10 different questions and for each correct question you will be awarded 1 point. Good luck!");

                Console.Write("\nPlease enter your name to begin: ");
                playerName = Console.ReadLine(); //I am welcoming the user to the quiz and asking for their name and assigning it to the name variable.

                Console.WriteLine("\nHello " + playerName + ", please choose your level: Easy, Medium or Hard (please type E for easy, M for Medium or H for Hard).");

                do
                {
                    selectedLevel = Console.ReadLine().ToUpper(); //Asks user what level they would like to play and takes input from them to decide this.
                    if (selectedLevel == "E")
                    {
                        Console.Clear();
                        level1();
                        valid = true;
                    }
                    else if (selectedLevel == "M")
                    {
                        Console.Clear();
                        level2();
                        valid = true;
                    }
                    else if (selectedLevel == "H")
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
                } while (valid != true); //This do while loop validates if the input entered by the user is accepted into the program, if it doesn't an error message will display and prompt the user to enter a valid option. The do loop ensures the input is proccessed at least once before checking if there is an error.
            }
        } //End of playing method.

        static void level1()
        {
            points += 0;
            Console.WriteLine("\nWelcome to the Easy level.");
        }
        static void level2()
        {
            points += 0;
            Console.WriteLine("\nWelcome to the Medium level.");
        }
        static void level3()
        {
            points += 0;
            Console.WriteLine("\nWelcome to the Hard level.");
        }
    } //End of main method.
}
