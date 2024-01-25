using System;

class Program
{
    public static void Main(string[] args)
    {
        //int topFive < 5;

        Console.WriteLine("Welcome to the Video Game Hall of fame");
        Console.WriteLine("Only you can choose the best of the best!");
        Console.WriteLine(" ");

        string[] games = new string[] {"Red Dead Redemption", "Super Mario Sunshine", "Alan Wake 2", "Pizza Tower", "Sly Cooper", "Breath of the Wild", "Catherine", "Call of Duty: Black Ops",
    "Resident Evil 4", "Dredge", "Armored Core 6", "The Last of Us"};
        string[] topFive = new string[5];

        int gameIndex = 0;

        foreach (var game in games)
        {
            Console.WriteLine($"\nDo you want to add {game} to the list? (yes/no)");
            string input = Console.ReadLine().ToLower();

            if (input == "yes")
            {
                topFive[gameIndex] = game;
                gameIndex++;
                //if gameIndex < 5 write the line "you've already maxed the list, you need to remove one if you want to add another" the player can type the exact name of the game in the list and the game will be removed from the list and tell the player "{game} has been removed from the list";
                Console.WriteLine($"{game} has been added to the list!");
            }

            else
            {
                Console.WriteLine($"{game} has been thrown in the trashcan");
            }
            //If the player writes "show me the top five" then the top five should be listed
            //if (input == "show me the list")
            //{

            //}
        }
        foreach (var member in topFive)
        {
            Console.WriteLine(member);
            Console.WriteLine(" ");
        }
        //Console.WriteLine("Here is your {topFive} ");
        //If the player types "show me the top five" then the top five should be listed
        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();

    }
}