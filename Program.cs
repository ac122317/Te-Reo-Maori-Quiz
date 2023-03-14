namespace Te_Reo_Maori_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;

            //I am welcome the using to the quiz and asking for their name and assigning it to the name variable.

            Console.WriteLine("\t\t\tWelcome to my Te Reo Maori Quiz.\nThis is a multiple choice quiz with three different levels, Easy, Medium and Hard. Good luck!");

            Console.Write("\nPlease enter your name to begin: ");
            name = Console.ReadLine();

            Console.WriteLine("\nHello " + name + ", please choose your level: Easy, Medium or Hard (please type E for easy, M for Medium or H for Hard).");


        }
    }
}