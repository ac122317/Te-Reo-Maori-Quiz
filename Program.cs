using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Te_Reo_Maori_Quiz
{
    internal class Program
    {
        static int points = 0;//Rather than creating an integer called points in the playing method I decided to create it inside the class Program, therefore I don't have to create parameters and reference points inside of the level methods.
        static void Main() //Beginning of main method.
        {
            points += 0;
            Playing();

            static void Playing() //Beginning of playing Method.
            {
                points += 0;

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
                            Level1();
                            valid = true;
                            break;

                        case "M":
                            Console.Clear();
                            Level2();
                            valid = true;
                            break;

                        case "H":
                            Console.Clear();
                            Level3();
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

        static void Level1()
        {
            points += 0;

            //Welcoming the user to the level and displaying their starting points.
            Console.WriteLine("Welcome to the Easy level.");
            Console.WriteLine("Your points are: " + points);

            //Creating an array for easy questions.
            string[] easyQuestions = {"\nQuestion 1: What is the Maori word for white? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Whero\n b) Ma\n c) Kikorangi\n d) Kowhai\n\nEnter answer below: "
                    ,
                "Question 2: What is the Maori word for hello? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Ka kite\n b) Whanau\n c) Kia ora\n d) Po marie\n\nEnter answer below: "
                    ,
                "Question 3: What is the Maori word for family? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Whanau\n b) Kia pai\n c) Awa\n d) Tena koe\n\nEnter answer below: "
                    ,
                "Question 4: What is the Maori name for New Zealand? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Aoraki\n b) Aotearoa\n c) Manukau\n d) Takanini\n\nEnter answer below: "
                    ,
                "Question 5: What is the Maori word for food? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Whenua\n b) Waka\n c) Tane\n d) Kai\n\nEnter answer below: "};

            //Creating an arrary for easy answers.
            string[] easyAnswers = { "b", "c", "a", "b", "d" };

            //Using a for loop to display each question to the user and taking their answer, then checking if their answer is correct and determining their points accordingly.
            for (int i = 0; i < easyQuestions.Length; i++)
            {
                Console.WriteLine(easyQuestions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                if (questionAnswer == easyAnswers[i])
                {
                    points += 1;
                    Console.WriteLine("\nCorrect! Your points are currently: " + points);
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Your points are currently: " + points);
                }
                Console.Write("\nPress any key to continue:");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Congratulations! You have successfully finished the easy level with " + points + "/5 points. \n\nPlease press r to restart the quiz from the beginning, m to go the medium level, h to go the hard level or press any other key to exit the quiz: ");
            String endOfLevelChoice = Console.ReadLine().ToLower();
            if (endOfLevelChoice.Contains("r"))
            {
                Console.Clear();
                Main();
            }
            else if (endOfLevelChoice.Contains("m"))
            {
                Console.Clear();
                Level2();
            }
            else if (endOfLevelChoice.Contains("h"))
            {
                Console.Clear();
                Level3();
            }
            else
            {
                Console.WriteLine("Thank you for playing my Te Reo Maori Quiz!");
            }

        }//End of level1 method.

        static void Level2()
        {
            points += 0;

            //Welcoming the user to the level and displaying their starting points.
            Console.WriteLine("Welcome to the Medium level.");
            Console.WriteLine("Your points are currently: " + points);

            //Creating an array for medium questions. 
            string[] mediumQuestions = {"\nQuestion 1: What is the Maori phrase for good morning? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Pai\n b) Ngati tama\n c) Ata marie\n d) Kia ora\n\nEnter answer below: "
                    ,
                "Question 2: What is the Maori word for tribe? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Patu\n b) Manu\n c) Iwi\n d) Harikoa\n\nEnter answer below: "
                    ,
                "Question 3: What is the Maori word for school? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Kura\n b) Whakaute\n c) Marae\n d) Kao\n\nEnter answer below: "
                    ,
                "Question 4: What is the Maori name for Auckland? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Te Upoko o te Ika a Maui\n b) Ahau\n c) Riri\n d) Tamaki Makaurau\n\nEnter answer below: "
                    ,
                "Question 5: What is the Maori word for land? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Kaimoana\n b) Whenua\n c) Whare\n d) Tepu\n\nEnter answer below: "
            };
            
            //Creating an array for medium answers.
            string[] mediumAnswers = {"c", "c", "a", "d", "b"};

            //Using a for loop to display each question to the user and taking their answer, then checking if their answer is correct and determining their points accordingly.
            for (int i = 0; i < mediumQuestions.Length; i++)
            {
                Console.WriteLine(mediumQuestions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                if (questionAnswer == mediumAnswers[i])
                {
                    points += 1;
                    Console.WriteLine("\nCorrect! Your points are currently: " + points);
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Your points are currently: " + points);
                }
                Console.Write("\nPress any key to continue:");
                Console.ReadKey();
                Console.Clear();
            } //End of for loop.

            Console.WriteLine("Congratulations! You have successfully finished the medium level with " + points + "/5 points. \n\nPlease press r to restart the quiz from the beginning, e to go to the easy level, h to go to the hard level, or press any other key to exit the quiz: ");
            String endOfLevelChoice = Console.ReadLine().ToLower();
            if (endOfLevelChoice.Contains("r"))
            {
                Console.Clear();
                Main();
            }
            else if (endOfLevelChoice.Contains("e"))
            {
                Console.Clear();
                Level1();
            }
            else if (endOfLevelChoice.Contains("h"))
            {
                Console.Clear();
                Level3();
            }
            else
            {
                Console.WriteLine("Thank you for playing my Te Reo Maori Quiz!");
            }
        } //End of level2 method.
        static void Level3()
        {
            points += 0;

            Console.WriteLine("Welcome to the Hard level.");
            Console.WriteLine("Your points are currently: " + points);

            //Creating an array for hard questions. 
            string[] hardQuestions = {"\nQuestion 1: What is the Maori word for shirt? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Ataahua\n b) Hate\n c) Whakarihariha\n d) Tika\n\nEnter answer below: "
                    ,
                "Question 2: What is the Maori word for shoe? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Hu\n b) Whitiki\n c) Turi\n d) Iti\n\nEnter answer below: "
                    ,
                "Question 3: What is the English word for kawe? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Tree\n b) Swallow\n c) Bring\n d) Grab\n\nEnter answer below: "
                    ,
                "Question 4: What is the English word for katakata? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Happiness\n b) Laughter\n c) Dance\n d) Military\n\nEnter answer below: "
                    ,
                "Question 5: What is the English word for rorohiko? (Please enter a, b, c or d)\n\nPlease enter one of the options:\n a) Headphones\n b) Door\n c) Pillar\n d) Computer\n\nEnter answer below: "
            }; 
            
            //Creating an array for hard answers.
            string[] hardAnswers = {"b","a","c","b","d"};

            //Using a for loop to display each question to the user and taking their answer, then checking if their answer is correct and determining their points accordingly.
            for (int i = 0; i < hardQuestions.Length; i++)
            {
                Console.WriteLine(hardQuestions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                if (questionAnswer == hardAnswers[i])
                {
                    points += 1;
                    Console.WriteLine("\nCorrect! Your points are currently: " + points);
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Your points are currently: " + points);
                }
                Console.Write("\nPress any key to continue:");
                Console.ReadKey();
                Console.Clear();
            } //End of for loop.

            Console.WriteLine("Congratulations! You have successfully finished the hard level with " + points + "/5 points. \n\nPlease press r to restart the quiz from the beginning, e to go to the easy level, m to go to the medium level, or press any other key to exit the quiz: ");
            String endOfLevelChoice = Console.ReadLine().ToLower();
            if (endOfLevelChoice.Contains("r"))
            {
                Console.Clear();
                Main();
            }
            else if (endOfLevelChoice.Contains("e"))
            {
                Console.Clear();
                Level1();
            }
            else if (endOfLevelChoice.Contains("m"))
            {
                Console.Clear();
                Level2();
            }
            else
            {
                Console.WriteLine("Thank you for playing my Te Reo Maori Quiz!");
            }
        } //End of level3 method.
    } //End of main method.
}
