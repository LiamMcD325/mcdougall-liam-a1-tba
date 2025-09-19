/* Name: Liam McDougall, 000878229
 * Date: 2025/09/16
 * Purpose: A text based adventure game, where the player will determine the most expensive item to sell
 *
 */
using System.Security.Cryptography.X509Certificates;

namespace mcdougall_liam_a1_tba
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Variables for item 1
            string name1 = "Pocket watch", condition1 = "acceptable", demand1 = "low, not many have sold", rarity1 = "One of a kind";
            int value1 = 5000;

            //Variables for item
            string name2 = "Snow globe", condition2 = "excellent", demand2 = "medium", rarity2 = "Over 100,000";
            int value2 = 1000;

            //Variables for item 3
            string name3 = "Toy car", condition3 = "poor, very scratched", demand3 = "high", rarity3 = "Around 5000 are left";
            int value3 = 10000;

            //Title screen
            Console.WriteLine("Appraisel \nPress the 'enter' key to continue. \nCreated by Liam McDougall.");
            string choice = Console.ReadLine();

            //Intro to the game and plot
            Console.WriteLine("Your father is moving houses, and needs to get rid of stuff. He places 3 item on the desk. 'I need  you to " +
                 "choose between my items here, pick what you believe the most expensive one and sell it! I consider them each equally " +
                 "sentimental. I just want the most amount of money from these old wedding gifts.'");

            Console.WriteLine("");
            do
            {
                Console.WriteLine("What do you want to do? Type 'sell' when you have made your decision. Type 'help' for a guide.");
                Console.WriteLine("Choices:  Condition, Demand, Rarity");
                Console.WriteLine("Items:  Pocket Watch, Snow Globe, Toy Car");
                //The player will make a choice for what they want to learn, and type an item in the same line: ie, "Demand Toy Car"
                choice = Console.ReadLine();

                //ToLower makes it so the users input will have a better chance of equalling what was typed
                choice = choice.ToLower();

                //Item 1 choices
                if ((choice == "condition pocket watch") || (choice == "condition item 1")) { Console.WriteLine(condition1); }
                else if ((choice == "demand pocket watch") || (choice == "demand item 1")) { Console.WriteLine(demand1); }
                else if ((choice == "rarity pocket watch") || (choice == "rarity item 1")) { Console.WriteLine(rarity1); }

                //Item 2 choices
                else if ((choice == "condition snow globe") || (choice == "condition item 2")) { Console.WriteLine(condition2); }
                else if ((choice == "demand snow globe") || (choice == "demand item 2")) { Console.WriteLine(demand2); }
                else if ((choice == "rarity snow globe") || (choice == "rarity item 2")) { Console.WriteLine(rarity2); }

                //Item 3 choices
                else if ((choice == "condition toy car") || (choice == "condition item 3")) { Console.WriteLine(condition3); }
                else if ((choice == "demand toy car") || (choice == "demand item 3")) { Console.WriteLine(demand3); }
                else if ((choice == "rarity toy car") || (choice == "rarity item 3")) { Console.WriteLine(rarity3); }

                //Help guide
                else if (choice == "help") {
                    Console.WriteLine("Your objective is to find the item with the best value. The value is determind by the highest average of" +
                        "condition, demand, and rarity. There are 3 choices for items: pocket watch, snow globe, and toy car" +
                        "To find out the various attributes, type a choice and item. For example, to find the condition of the " +
                        "snow globe, type 'condition snow globe'. When you have done enough research, type 'sell'. You will then " +
                        "be prompted to type an item to sell. You will then find out the value of the items to see if you made the best" +
                        "decision");
                }

                Console.WriteLine("\n");
            } while ((choice != "sell"));

            //Now that the user has made a decision, they will type their choice.
            Console.WriteLine("So what item do you want to sell? Pocket Watch, Snow Globe, or Toy Car?");

            //Will only exit the loop if the user has correctly typed an option
            Boolean quit = false;
            do
            {
                choice = Console.ReadLine();
                //Makes the user unable to make an error by including different capitalizations
                choice = choice.ToLower();

                if (choice == "pocket watch") { quit = true; }
                else if (choice == "snow globe") { quit = true; }
                else if (choice == "toy car") { quit = true; }
                else { Console.WriteLine("What was that? I didn't quite catch that."); }
            } while (quit != true);

        }
    }
}
