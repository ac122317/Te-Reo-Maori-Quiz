namespace Te_Reo_Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            playing();
            
            static void playing()
            {
                String name, level;
                
                //I am welcoming the user to the quiz and asking for their name and assigning it to the name variable.

                Console.WriteLine("\t\t\tWelcome to my Te Reo Maori Quiz.\nThis is a multiple choice quiz with three different levels, Easy, Medium and Hard. Good luck!");

                Console.Write("\nPlease enter your name to begin: ");
                name = Console.ReadLine();

                Console.WriteLine("\nHello " + name + ", please choose your level: Easy, Medium or Hard (please type E for easy, M for Medium or H for Hard).");
                level = Console.ReadLine().ToUpper();

                if (level == "E")
                {
                    level1();
                }
                else if (level == "M")
                {
                    level2();
                }
                else if (level == "H")
                {
                    level3();
                }
            }
            static void level1()
            {
                Console.WriteLine("Welcome to the Easy level.");
            }
            static void level2()
            {
                Console.WriteLine("Welcome to the Medium level.");
            }
            static void level3()
            {
                Console.WriteLine("Welcome to the Hard level.");
            }
        }
    }
}