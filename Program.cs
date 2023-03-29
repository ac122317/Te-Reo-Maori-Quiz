﻿using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Te_Reo_Maori_Quiz
{
    internal class Program
    {
        static void Main() //Beginning of main method.
        {
            int points = 0;
            Playing(points);

            static void Playing(int points) //Beginning of playing Method.
            {
                points = 0;

                String playerName, selectedLevel;
                bool valid;

                Console.WriteLine("\t\t\tWelcome to my Te Reo Maori Quiz.\nThis is a multiple choice quiz with three different levels, Easy, Medium and Hard. Each level will have 5 different questions and for each correct question you will be awarded 1 point. Good luck!");

                Console.Write("\nPlease enter your name to begin: "); //I am welcoming the user to the quiz and asking for their name.

                playerName = Console.ReadLine(); // I am now assigning their input to the name variable.
                while (string.IsNullOrEmpty(playerName))
                {
                    Console.Write("Please enter a name with at least 1 character: ");
                    playerName = Console.ReadLine();
                }

                Console.WriteLine("\nHello " + playerName + ", please choose your level: Easy (type E), Medium (type M) or Hard (type H).");
                Console.Write("\nPlease enter your choice here: ");

                do
                {
                    selectedLevel = Console.ReadLine().ToUpper(); //Asks user what level they would like to play and takes input from them to decide this.

                    switch (selectedLevel) //This switch will check the input from the user and validate whether it is accepted according to each case. If accepted the user will be sent to the corresponding level method based on their selection, otherwise an error will display and loop back to take an appropriate input.
                    {
                        case "E":
                            Console.Clear();
                            Level1(playerName, points);
                            valid = true;
                            break;

                        case "M":
                            Console.Clear();
                            Level2(playerName, points);
                            valid = true;
                            break;

                        case "H":
                            Console.Clear();
                            Level3(playerName, points);
                            valid = true;
                            break;

                        default:
                            Console.Write("Please enter a valid level: ");
                            valid = false;
                            break;
                    }
                } while (valid != true); //This do while loop validates if the input entered by the user is accepted into the program, if it doesn't an error message will display and prompt the user to enter a valid option. The do loop ensures the input is proccessed at least once before checking if there is an error.
            }
        } //End of playing method.

        static void Level1(string playerName, int points) //Beginning of Level1 method.
        {
            points = 0;
            
            //Welcoming the user to the level and displaying their starting points.
            Console.WriteLine("Welcome to the Easy level " + playerName + ".");

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
            string[] easyAnswersWBracket = { "b)", "c)", "a)", "b)", "d)" };
            //Using a for loop to display each question to the user and taking their answer, then checking if their answer is correct and determining their points accordingly.

            for (int i = 0; i < easyQuestions.Length; i++)
            {
                Console.WriteLine(easyQuestions[i]);
                String questionAnswer = Console.ReadLine().ToLower();
                
                while (string.IsNullOrEmpty(questionAnswer)) //Checks if the user doesn't enter an answer.
                {
                    Console.Write("Please enter an answer: ");
                    questionAnswer = Console.ReadLine().ToLower();
                } //End of while loop.

                if (questionAnswer.Contains(easyAnswers[i]) || questionAnswer.Contains (easyAnswersWBracket[i]))
                {
                    points++;
                    Console.WriteLine("\nCorrect! Your points are currently: " + points);
                }
                else
                {
                    Console.WriteLine("\nIncorrect. The answer was " + easyAnswers[i] + "." + "\nYour points are currently: " + points);
                }
                Console.Write("\nPress any key to continue: ");
                Console.ReadKey();
                Console.Clear();
            } //End of for loop.

            Console.WriteLine("Congratulations! You have finished the medium level with " + points + "/5 points. \n\nPlease press r to restart the whole quiz, e to restart the easy level, m to go to the medium level, h to go to the hard level, or any other key to exit: ");

            String endOfLevelChoice = Console.ReadLine().ToLower();
            if (endOfLevelChoice.Contains("r"))
            {
                Console.Clear();
                Main();
            }
            else if (endOfLevelChoice.Contains("e"))
            {
                Console.Clear();
                Level1(playerName, points);
            }
            else if (endOfLevelChoice.Contains("m"))
            {
                Console.Clear();
                Level2(playerName, points);
            }
            else if (endOfLevelChoice.Contains("h"))
            {
                Console.Clear();
                Level3(playerName, points);
            }
            else
            {
                Console.WriteLine("Thank you for playing my Te Reo Maori Quiz!");
            }

        }//End of level1 method.

        static void Level2(string playerName, int points) //Beginning of Level2 method.
        {
            points = 0;

            //Welcoming the user to the level and displaying their starting points.
            Console.WriteLine("Welcome to the Medium level " + playerName + ".");

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
            string[] mediumAnswersWBracket = { "c)", "c)", "a)", "d)", "b)" };

            //Using a for loop to display each question to the user and taking their answer, then checking if their answer is correct and determining their points accordingly.
            for (int i = 0; i < mediumQuestions.Length; i++)
            {
                Console.WriteLine(mediumQuestions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                while (string.IsNullOrEmpty(questionAnswer)) //Checks if the user doesn't enter an answer.
                {
                    Console.Write("Please enter an answer: ");
                    questionAnswer = Console.ReadLine().ToLower();
                } //End of while loop.

                if (questionAnswer.Contains(mediumAnswers[i]) || questionAnswer.Contains(mediumAnswersWBracket[i]))
                {
                    points++;
                    Console.WriteLine("\nCorrect! Your points are currently: " + points);
                }
                else
                {
                    Console.WriteLine("\nIncorrect. The answer was " + mediumAnswers[i] + "." + "\nYour points are currently: " + points);
                }
                Console.Write("\nPress any key to continue: ");
                Console.ReadKey();
                Console.Clear();
            } //End of for loop.

            Console.WriteLine("Congratulations! You have finished the medium level with " + points + "/5 points. \n\nPlease press r to restart the whole quiz, e to go to the easy level, m to restart the medium level, h to go to the hard level, or any other key to exit: "); 

            String endOfLevelChoice = Console.ReadLine().ToLower();
            if (endOfLevelChoice.Contains("r"))
            {
                Console.Clear();
                Main();
            }
            else if (endOfLevelChoice.Contains("e"))
            {
                Console.Clear();
                Level1(playerName, points);
            }
            else if (endOfLevelChoice.Contains("m"))
            {
                Console.Clear();
                Level2(playerName, points);
            }
            else if (endOfLevelChoice.Contains("h"))
            {
                Console.Clear();
                Level3(playerName, points);
            }
            else
            {
                Console.WriteLine("Thank you for playing my Te Reo Maori Quiz!");
            }
        } //End of level2 method.
        static void Level3(string playerName, int points) //Beginning of Level3 method.
        {
            points = 0;

            //Welcoming the user to the level and displaying their starting points.
            Console.WriteLine("Welcome to the Hard level " + playerName + ".");

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
            string[] hardAnswersWBracket = { "b)", "a)", "c)", "b)", "d)" };
            //Using a for loop to display each question to the user and taking their answer, then checking if their answer is correct and determining their points accordingly.
            for (int i = 0; i < hardQuestions.Length; i++)
            {
                Console.WriteLine(hardQuestions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                while (string.IsNullOrEmpty(questionAnswer)) //Checks if the user doesn't enter an answer.
                {
                    Console.Write("Please enter an answer: ");
                    questionAnswer = Console.ReadLine().ToLower();
                } //End of while loop.

                if (questionAnswer.Contains(hardAnswers[i]) || questionAnswer.Contains(hardAnswersWBracket[i]))
                {
                    points++;
                    Console.WriteLine("\nCorrect! Your points are currently: " + points);
                }
                else
                {
                    Console.WriteLine("\nIncorrect. The answer was " + hardAnswers[i] + "." + "\nYour points are currently: " + points);
                }
                Console.Write("\nPress any key to continue:");
                Console.ReadKey();
                Console.Clear();
            } //End of for loop.

            Console.WriteLine("Congratulations! You have finished the medium level with " + points + "/5 points. \n\nPlease press r to restart the whole quiz, e to go to the easy level, m to go to the medium level, h to restart the hard level, or any other key to exit: ");

            String endOfLevelChoice = Console.ReadLine().ToLower();
            if (endOfLevelChoice.Contains("r"))
            {
                Console.Clear();
                Main();
            }
            else if (endOfLevelChoice.Contains("e"))
            {
                Console.Clear();
                Level1(playerName, points);
            }
            else if (endOfLevelChoice.Contains("m"))
            {
                Console.Clear();
                Level2(playerName, points);
            }
            else if (endOfLevelChoice.Contains("h"))
            {
                Console.Clear();
                Level3(playerName, points);
            }
            else
            {
                Console.WriteLine("Thank you for playing my Te Reo Maori Quiz!");
            }
        } //End of level3 method.
    } //End of main method.
}