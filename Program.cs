using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Te_Reo_Maori_Quiz
{
    internal class Program
    {
        static void Main() //Beginning of main method.
        {
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

            Console.WriteLine("\nHello " + playerName + ", please choose your level: Easy (type E), Medium (type M) or Hard (type H).");
            Console.Write("\nPlease enter your choice here: "); //Asking which level user wants to play.

            do //Beginning of do loop.
            {
                selectedLevel = Console.ReadLine().ToUpper(); //Reads user input, converts to uppercase and assigns to variable selectedLevel.

                switch (selectedLevel) //This switch checks if the user inputs a valid level choice. If so, will be taken to level by calling the corresponding method. Otherwise, error message is displayed.
                {
                    case "E":
                        Console.Clear();
                        Level1(playerName, points);
                        validChoice = true;
                        break;

                    case "M":
                        Console.Clear();
                        Level2(playerName, points);
                        validChoice = true;
                        break;

                    case "H":
                        Console.Clear();
                        Level3(playerName, points);
                        validChoice = true;
                        break;

                    default:
                        Console.Write("Please enter a valid level: ");
                        validChoice = false;
                        break;
                }
            } while (validChoice != true); //While loop allows the do loop to repeat when the user doesn't enter one of the accepted cases in the switch.
        } //End of main method.

        static void Level1(string playerName, int points) //Beginning of Level1 method.
        {
            points = 0;

            //Welcoming the user to the level.
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
            
            //Using a for loop to display each question to the user and taking their answer, if input is a correct answer, points increment by 1.
            for (int i = 0; i < easyQuestions.Length; i++) //Beginning of for loop.
            {
                Console.WriteLine(easyQuestions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                while (string.IsNullOrEmpty(questionAnswer)) //Beginning of while loop, checks if user enters nothing.
                {
                    Console.Write("Please enter an answer: ");
                    questionAnswer = Console.ReadLine().ToLower();
                } //End of while loop.

                if (questionAnswer.Equals(easyAnswers[i]) || questionAnswer.Equals(easyAnswersWBracket[i]))
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

            Console.WriteLine("Congratulations! You have finished the medium level with " + points + "/5 points. \n\nPlease press r to restart the whole quiz, e to restart the easy level, m to go to the medium level, h to go to the hard level, or any other key to exit: "); //Congratulates and shows the user their final points and prompts themm to make a selection on what to do after finishing the level.

            EndLevelChoice(points, playerName);

        }//End of level1 method.

        static void Level2(string playerName, int points) //Beginning of Level2 method.
        {
            points = 0;

            //Welcoming the user to the level.
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

            //Using a for loop to display each question to the user and taking their answer, if input is a correct answer, points increment by 1.
            for (int i = 0; i < mediumQuestions.Length; i++) //Beginning of for loop.
            {
                Console.WriteLine(mediumQuestions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                while (string.IsNullOrEmpty(questionAnswer)) //Beginning of while loop, checks if user enters nothing.
                {
                    Console.Write("Please enter an answer: ");
                    questionAnswer = Console.ReadLine().ToLower();
                } //End of while loop.

                if (questionAnswer.Equals(mediumAnswers[i]) || questionAnswer.Equals(mediumAnswersWBracket[i]))
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

            Console.WriteLine("Congratulations! You have finished the medium level with " + points + "/5 points. \n\nPlease press r to restart the whole quiz, e to go to the easy level, m to restart the medium level, h to go to the hard level, or any other key to exit: "); //Congratulates and shows the user their final points and prompts themm to make a selection on what to do after finishing the level.

            EndLevelChoice(points, playerName);
            
        } //End of level2 method.
        static void Level3(string playerName, int points) //Beginning of Level3 method.
        {
            points = 0;

            //Welcoming the user to the level.
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

            //Using a for loop to display each question to the user and taking their answer, if input is a correct answer, points increment by 1.
            for (int i = 0; i < hardQuestions.Length; i++) //Beginning of for loop.
            {
                Console.WriteLine(hardQuestions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                while (string.IsNullOrEmpty(questionAnswer)) //Beginning of while loop, checks if user enters nothing.
                {
                    Console.Write("Please enter an answer: ");
                    questionAnswer = Console.ReadLine().ToLower();
                } //End of while loop.

                if (questionAnswer.Equals(hardAnswers[i]) || questionAnswer.Equals(hardAnswersWBracket[i]))
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

            Console.WriteLine("Congratulations! You have finished the medium level with " + points + "/5 points. \n\nPlease press r to restart the whole quiz, e to go to the easy level, m to go to the medium level, h to restart the hard level, or any other key to exit: "); //Congratulates and shows the user their final points and prompts themm to make a selection on what to do after finishing the level.

            EndLevelChoice(points, playerName);
            
        } //End of level3 method.

        static void EndLevelChoice(int points, string playerName) //This method determines what happens next in the quiz after finishing the level based on uesr input.
        {
            String endOfLevelChoice = Console.ReadLine().ToLower();
            if (endOfLevelChoice.Equals("r"))
            {
                Console.Clear();
                Main();
            }
            else if (endOfLevelChoice.Equals("e"))
            {
                Console.Clear();
                Level1(playerName, points);
            }
            else if (endOfLevelChoice.Equals("m"))
            {
                Console.Clear();
                Level2(playerName, points);
            }
            else if (endOfLevelChoice.Equals("h"))
            {
                Console.Clear();
                Level3(playerName, points);
            }
            else
            {
                Console.WriteLine("Thank you for playing my Te Reo Maori Quiz" + playerName + "!");
            }
        }//End of EndLevelChoice method.
    } //End of Program class.
} //End of Te_Reo_Maori_Quiz namespace.