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

            //Creating an array for easy answers.
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

            //Creating an array for medium answers.
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

            //Creating an array for hard answers.
            string[] hardAnswers = { "b", "a", "c", "b", "d" };

            //Declaring necessary variables.
            int points = 0;
            String playerName, selectedLevel;
            bool newLevel;

            //Welcoming the user and asking for their name.
            Console.WriteLine("\t\t\tWelcome to my Te Reo Maori Quiz.\nThis is a multiple choice quiz with three different levels, Easy, Medium and Hard. Each level will have 5 different questions and for each correct question you will be awarded 1 point. Good luck!");
            Console.Write("\nPlease enter your name to begin: ");

            playerName = Console.ReadLine(); //Assigning user input to playerName variable.
            while (string.IsNullOrEmpty(playerName)) //Beginning of while loop to ensure user inputs at least 1 character for name.
            {
                Console.Write("Please enter a name with at least 1 character: ");
                playerName = Console.ReadLine();
            } //End of while loop.

            do //Beginning of the do loop where most of the non-array coding in the main method takes place.
            {
                Console.WriteLine("\n" + playerName + ", please select the level you would like to play: Easy (type E), Medium (type M) or Hard (type H).");
                Console.Write("\nPlease enter your choice here: "); //Asking which level user wants to play.

                selectedLevel = Console.ReadLine().ToUpper(); //Reads user input, converts to uppercase and assigns to variable selectedLevel.

                while (selectedLevel != "E" && selectedLevel != "M" && selectedLevel != "H") //Beginning of while loop to ensure user selects a valid level.
                {
                    Console.Write("\nPlease enter a valid level: ");
                    selectedLevel = Console.ReadLine().ToUpper();
                } //End of while loop.

                Console.Clear(); //Clears console for cleanliness.

                //The following if and else if statements take the user to their chosen level.
                if (selectedLevel.Equals("E"))
                {
                    points = QandA(easyQuestions, easyAnswers, "easy", playerName); //Calls the QandA method and parses through the necessary variables for easy level.
                }
                else if (selectedLevel.Equals("M"))
                {
                    points = QandA(mediumQuestions, mediumAnswers, "medium", playerName); //Calls the QandA method and parses through the necessary variables for medium level.
                }
                else if (selectedLevel.Equals("H"))
                {
                    points = QandA(hardQuestions, hardAnswers, "hard", playerName); //Calls the QandA method and parses through the necessary variables for hard level.
                }

                Console.WriteLine("Congratulations " + playerName + "!" + " You have finished the level with " + points + "/5 points."); //Congratulates the user on finishing the level and displays their final points.

                Console.WriteLine("Would you like to play another level? (Y/N): "); //Asks if the user wants to play again.

                string endLevelSelection = Console.ReadLine().ToUpper(); //Storing user input in endLevelSelection variable.

                while (!endLevelSelection.Equals("Y") && !endLevelSelection.Equals("N")) //Beginning of while loop to ensure user inputs "Y" or "N".
                {
                    Console.WriteLine("Please type Y or N:");
                    endLevelSelection = Console.ReadLine().ToUpper();
                } //End of while loop.

                if (endLevelSelection.Equals("Y"))
                {
                    newLevel = true;
                }
                else
                {
                    newLevel = false;
                }
            } while (newLevel != false); //This while loop allows another level to be chosen if the user selects yes.

            Console.WriteLine("\nThank you for playing my Te Reo Maori Quiz " + playerName + ", I hoped you enjoyed it and learnt more about the Maori culture!"); //End message after the user says they do not want to do another level.
        } //End of main method.

        static int QandA(string[] questions, string[] answers, string level, string playerName) //Beginning of QandA method.
        {
            int points = 0;

            Console.WriteLine("Welcome to the " + level + " level " + playerName + "!");
            for (int i = 0; i < questions.Length; i++) //Beginning of for loop where the questions and answers are processed.
            {
                Console.WriteLine(questions[i]);
                String questionAnswer = Console.ReadLine().ToLower();

                //Beginning of while loop, ensures the user enters a, b, c, or d as their answer.
                while (!questionAnswer.Equals("a") && !questionAnswer.Equals("b") && !questionAnswer.Equals("c") && !questionAnswer.Equals("d"))
                {
                    Console.WriteLine("Please enter one of the options (a, b, c or d): ");
                    questionAnswer = Console.ReadLine().ToLower();
                } //End of while loop.

                //Next section of code determines whether the user's answer is correct.
                if (questionAnswer.Equals(answers[i]))
                {
                    points++;
                    Console.WriteLine("\nCorrect! Your points are currently: " + points);
                }
                else
                {
                    Console.WriteLine("\nIncorrect. The answer was " + answers[i] + "." + "\nYour points are currently: " + points);
                }

                //Prompts user to press a key to continue to the next question.
                Console.Write("\nPress any key to continue:");
                Console.ReadKey();
                Console.Clear();
            } //End of for loop.

            return points; //returns the users points after completion.

        } //End of QandA method.
    } //End of Program class.
} //End of Te_Reo_Maori_Quiz namespace.