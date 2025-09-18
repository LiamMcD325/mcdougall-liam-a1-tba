/* Name: Liam McDougall, 000878229
 * Date: 2025/09/16
 * Purpose: A text based adventure game
 *
 */
using System.Security.Cryptography.X509Certificates;

namespace mcdougall_liam_a1_tba
{
    internal class Program
    {
        /*Variables for item 1*/
        string name1 = "Pocket watch", condition1 = "excellent", demand1 = "low, not many have sold", rarity1 = "One of a kind";
        int value1 = 10;

        /*Variables for item 2*/
        string name2 = "ITEM 2", condition2 = "excellent", demand2 = "low, not many have sold", rarity2 = "One of a kind";
        int value2 = 10;

        /*Variables for item 3*/
        string name3 = "ITEM 3", condition3 = "excellent", demand3 = "low, not many have sold", rarity3 = "One of a kind";
        int value3 = 10;

        static void Main(string[] args)
        {
            //Title screen
            Console.WriteLine("Appraisel \nPress the 'enter' key to continue. \nCreated by Liam McDougall.");
            string choice = Console.ReadLine();

            //Intro to the game and plot
            Console.WriteLine("Your father walks into the room. He places 3 item on the desk. 'I need  you to " +
                 "choose between my items here, pick what you believe the most expensive one and sell it!'");

            Console.WriteLine("");
            do
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("Condition, Demand, Rarity");
                choice = Console.ReadLine();
                choice = choice.ToLower();
                if ((choice == "condition pocket watch")||(choice == "condition item 1"))
                {
                    Console.WriteLine("puppy");
                    choice = "";
                }
            } while (choice != "");

        }
    }
}
