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
                bool playerNameCheck = true;
                Console.WriteLine("\t\t\tWelcome to my Te Reo Maori Quiz.\nThis is a multiple choice quiz with three different levels, Easy, Medium and Hard. Each level will have 5 different questions and for each correct question you will be awarded 1 point. Good luck!");

                Console.Write("\nPlease enter your name to begin: "); //I am welcoming the user to the quiz and asking for their name.

                do //Creating a do loop to ensure the name check is done at least once.
                {
                    playerName = Console.ReadLine(); // I am now assigning their input to the name variable.

                    if (string.IsNullOrEmpty(playerName)) //This if statement checks if the user doesn't input anything and just presses enter. If so, they will be prompted to enter a name with at least 1 character. If they follow the instructions the loop will be broken, otherwise it will loop until the condition is met.
                    {
                        Console.Write("Please enter a name with at least 1 character: ");
                        playerNameCheck = false;
                    }
                    else
                    {
                        break;
                    }
                } while (playerNameCheck != true); //Ensures the loop repeats if the playerNameCheck does not equal true.

                Console.WriteLine("\nHello " + playerName + ", please choose your level: Easy, Medium or Hard (please type E for easy, M for Medium or H for Hard).");

                do
                {
                    selectedLevel = Console.ReadLine().ToUpper(); //Asks user what level they would like to play and takes input from them to decide this.

                    switch (selectedLevel) //This switch will check the input from the user and validate whether it is accepted according to each case. If accepted the user will be sent to the corresponding level method based on their selection, otherwise an error will display and loop back to take an appropriate input.
                    {
                        case "E":
                            Console.Clear();
                            level1();
                            valid = true;
                            break;

                        case "M":
                            Console.Clear();
                            level2();
                            valid = true;
                            break;

                        case "H":
                            Console.Clear();
                            level3();
                            valid = true;
                            break;

                        default:
                            Console.Write("Please enter a valid option: ");
                            valid = false;
                            break;
                    }
                } while (valid != true); //This do while loop validates if the input entered by the user is accepted into the program, if it doesn't an error message will display and prompt the user to enter a valid option. The do loop ensures the input is proccessed at least once before checking if there is an error.
            }
        } //End of playing method.

        static void level1()
        {
            String answer1;
            string[] easyQuestions = {"\nQuestion 1: What is the Maori word for White? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Whero\n b) Ma\n c) Kikorangi\n d) Kowhai\n\nEnter answer below: "};
            string[] easyAnswers = {"b"};
            points += 0;
            Console.WriteLine("Welcome to the Easy level.");
            Console.WriteLine("Your points are currently: " +points);

            Console.WriteLine(easyQuestions[0]);
            easyAnswers[0] = Console.ReadLine().ToLower();

            switch (easyAnswers[0])
            {
                case "b":
                    points += 1;
                    Console.WriteLine("Correct! Your points are now: " + points);
                    break;

                default:
                    Console.WriteLine("Incorrect. Your points are still: " +points);
                    break;
            }
        } //End of level1 method.
        static void level2()
        {
            points += 0;
            Console.WriteLine("Welcome to the Medium level.");
            Console.WriteLine("Your points are currently: " + points);
        } //End of level2 method.
        static void level3()
        {
            points += 0;
            Console.WriteLine("Welcome to the Hard level.");
            Console.WriteLine("Your points are currently: " + points);
        } //End of level3 method.

    } //End of main method.
}
