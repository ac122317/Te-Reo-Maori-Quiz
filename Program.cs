using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Emit;

namespace Te_Reo_Maori_Quiz
{
    internal class Program
    {
        static void Main() //Beginning of main method.
        {
            //Creating an array for easy questions.
            string[] easyQuestions = {"\nQuestion 1: What is the Maori word for white?\n\nPlease enter one of the options (by letter):\n a) Whero\n b) Ma\n c) Kikorangi\n d) Kowhai\n\nEnter answer below: "
                    ,
                "Question 2: What is the Maori word for hello?\n\nPlease enter one of the options (by letter):\n a) Ka kite\n b) Whanau\n c) Kia ora\n d) Po marie\n\nEnter answer below: "
                    ,
                "Question 3: What is the Maori word for family?\n\nPlease enter one of the options (by letter):\n a) Whanau\n b) Kia pai\n c) Awa\n d) Tena koe\n\nEnter answer below: "
                    ,
                "Question 4: What is the Maori name for New Zealand?\n\nPlease enter one of the options (by letter):\n a) Aoraki\n b) Aotearoa\n c) Manukau\n d) Takanini\n\nEnter answer below: "
                    ,
                "Question 5: What is the Maori word for food?\n\nPlease enter one of the options (by letter):\n a) Whenua\n b) Waka\n c) Tane\n d) Kai\n\nEnter answer below: "};

            //Creating arrays for easy answers.
            string[] easyAnswers = { "b", "c", "a", "b", "d" };

            //Creating an array for medium questions. 
            string[] mediumQuestions = {"\nQuestion 1: What is the Maori phrase for good morning?\n\nPlease enter one of the options (by letter):\n a) Pai\n b) Ngati tama\n c) Ata marie\n d) Kia ora\n\nEnter answer below: "
                    ,
                "Question 2: What is the Maori word for tribe?\n\nPlease enter one of the options (by letter):\n a) Patu\n b) Manu\n c) Iwi\n d) Harikoa\n\nEnter answer below: "
                    ,
                "Question 3: What is the Maori word for school?\n\nPlease enter one of the options (by letter):\n a) Kura\n b) Whakaute\n c) Marae\n d) Kao\n\nEnter answer below: "
                    ,
                "Question 4: What is the Maori name for Auckland?\n\nPlease enter one of the options (by letter):\n a) Te Upoko o te Ika a Maui\n b) Ahau\n c) Riri\n d) Tamaki Makaurau\n\nEnter answer below: "
                    ,
                "Question 5: What is the Maori word for land? (Please enter a, b, c or d)\n\nPlease enter one of the options (by letter):\n a) Kaimoana\n b) Whenua\n c) Whare\n d) Tepu\n\nEnter answer below: "
            };

            //Creating arrays for medium answers.
            string[] mediumAnswers = { "c", "c", "a", "d", "b" };

            //Creating an array for hard questions. 
            string[] hardQuestions = {"\nQuestion 1: What is the Maori word for shirt?\n\nPlease enter one of the options (by letter):\n a) Ataahua\n b) Hate\n c) Whakarihariha\n d) Tika\n\nEnter answer below: "
                    ,
                "Question 2: What is the Maori word for shoe?\n\nPlease enter one of the options (by letter):\n a) Hu\n b) Whitiki\n c) Turi\n d) Iti\n\nEnter answer below: "
                    ,
                "Question 3: What is the English word for kawe?\n\nPlease enter one of the options (by letter):\n a) Tree\n b) Swallow\n c) Bring\n d) Grab\n\nEnter answer below: "
                    ,
                "Question 4: What is the English word for katakata?\n\nPlease enter one of the options (by letter):\n a) Happiness\n b) Laughter\n c) Dance\n d) Military\n\nEnter answer below: "
                    ,
                "Question 5: What is the English word for rorohiko?\n\nPlease enter one of the options (by letter):\n a) Headphones\n b) Door\n c) Pillar\n d) Computer\n\nEnter answer below: "
            };

            //Creating arrays for hard answers.
            string[] hardAnswers = { "b", "a", "c", "b", "d" };

            int points = 0;

            String playerName, selectedLevel;
            bool validChoice;
          
            //Welcoming the user and asking for their name.
            Console.WriteLine("\t\t\tWelcome to my Te Reo Maori Quiz.\nThis is a multiple choice quiz with three different levels, Easy, Medium and Hard. Each level will have 5 different questions and for each correct question you will be awarded 1 point. Good luck!");
            Console.Write("\nPlease enter your name to begin: ");

            playerName = Console.ReadLine(); //Assigning user input to playerName variable.
            while (string.IsNullOrEmpty(playerName)) //Beginning of while loop to see if user inputs at least 1 character.
            {
                Console.Write("Please enter a name with at least 1 character: ");
                playerName = Console.ReadLine();
            } //End of while loop.

            do //Beginning of 1st do loop.
            {
                Console.WriteLine("\n" + playerName + ", please select the level you would like to play: Easy (type E), Medium (type M) or Hard (type H).");
                Console.Write("\nPlease enter your choice here: "); //Asking which level user wants to play.

                do //Beginning of 2nd do loop, where users input goes through a switch to determine what level is chosen.
                {
                    selectedLevel = Console.ReadLine().ToUpper(); //Reads user input, converts to uppercase and assigns to variable selectedLevel.

                    switch (selectedLevel) //This switch checks if the user inputs a valid level choice. If so, will be taken to level by parsing through the necessary variables to the QandA method. If E, M, or H aren't chosen, error message is displayed and loops back.
                    {
                        case "E":
                            Console.Clear();
                            points = QandA(easyQuestions, easyAnswers, "easy", playerName); //Calls the QandA method and parses through the necessary variables for easy level.
                            validChoice = true;
                            break;

                        case "M":
                            Console.Clear();
                            points = QandA(mediumQuestions, mediumAnswers, "medium", playerName); //Calls the QandA method and parses through the necessary variables for medium level.
                            validChoice = true;
                            break;

                        case "H":
                            Console.Clear();
                            points = QandA(hardQuestions, hardAnswers, "hard", playerName); //Calls the QandA method and parses through the necessary variables for hard level.
                            validChoice = true;
                            break;

                        default:
                            Console.Write("Please enter a valid level: ");
                            validChoice = false;
                            break;
                    }
                } while (validChoice != true); //This while loop allows the do loop to repeat when the user doesn't enter one of the accepted cases in the switch.
            } while (RedoQuiz(playerName, points)); //This while loop allows the level selection part of the quiz to repeat again, if the user says they would like to play another level in the RedoQuiz method.

            Console.WriteLine("\nThank you for playing my Te Reo Maori Quiz " + playerName + ", I hoped you enjoyed it and learnt more about the Maori culture!"); //End message after the user says they do not want to do another level.
        } //End of main method.

        static int QandA(string[] questions, string[] answers, string level, string playerName) //Beginning of QandA method.
        {
            int points = 0;
            bool validAnswer;

            Console.WriteLine("Welcome to the " + level + " level " + playerName + "!");
            for (int i = 0; i < questions.Length; i++) //Beginning of for loop.
            {
                Console.WriteLine(questions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                do //Beginning of do while loop, ensures the user enters a, b, c, or d as their answer.
                {
                    if (!questionAnswer.Equals("a") && !questionAnswer.Equals("b") && !questionAnswer.Equals("c") && !questionAnswer.Equals("d"))
                    {
                        Console.WriteLine("Please enter one of the options (a, b, c or d): ");
                        validAnswer = false;
                        questionAnswer = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        validAnswer = true;
                    }
                } while (validAnswer != true); //End of do while loop.

                if (questionAnswer.Equals(answers[i]))
                {
                    points++;
                    Console.WriteLine("\nCorrect! Your points are currently: " + points);
                }
                else
                {
                    Console.WriteLine("\nIncorrect. The answer was " + answers[i] + "." + "\nYour points are currently: " + points);
                }
                Console.Write("\nPress any key to continue:");
                Console.ReadKey();
                Console.Clear();
            } //End of for loop.

            return points;
        } //End of QandA method.
        static bool RedoQuiz(string playerName, int points) //Beginning of RedoQuiz method.
        {
            bool validSelection;

            Console.WriteLine("Congratulations " + playerName + "!" + " You have finished the level with " + points + "/5 points."); //Congratulates the user on finishing the level and displays their points.
            Console.WriteLine("Would you like to play another level? (Y/N): ");

            string selection = Console.ReadLine().ToUpper();

            do //Beginning of do while loop, ensures the user enters Y or N.
            {
                if (!selection.Equals("Y") && !selection.Equals("N"))
                {
                    Console.WriteLine("Please type Y or N:");
                    validSelection = false;
                    selection = Console.ReadLine().ToUpper();
                }
                else
                {
                    validSelection = true;
                }
            } while (validSelection != true); //End of do while loop.

            if (selection.Equals("Y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        } //End of RedoQuiz method.
    } //End of Program class.
} //End of Te_Reo_Maori_Quiz namespace.