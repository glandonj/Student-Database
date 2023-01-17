


string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn",
    "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim",
    "Jason Garrison", "Cam Dixon", "Josh Strathres" };
string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland",
    "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };
string[] food = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza",
    "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

Console.WriteLine("Welcome to the Secret Grand Circus C#.Net student list!");
Console.WriteLine();
bool runProgram = true;
while (runProgram)
{
    int selection = 0;
    int tries = 0;
    while (selection <= 0 || selection >= names.Length)
    { if(tries > 0)
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
        Console.Write("Which student would you like to learn about?\nPlease enter a number 1-" + (names.Length) + ": ");
        selection = int.Parse(Console.ReadLine())-1;
        tries++;
    }
    
    Console.WriteLine($"Student {selection + 1} is {names[selection]}.");
    Console.Write("What would you like to know?  Please enter hometown or favorite food. ");
    string choice = Console.ReadLine().ToLower().Trim();
    if (choice == "hometown" || choice == "home town" || choice == "home" || choice == "town")
    {
        Console.WriteLine($"{names[selection]}'s hometown is {towns[selection]}.");
    }
    else if (choice == "favorite food" || choice == "favorite" || choice == "food" || choice == "favoritefood")
    {
        Console.WriteLine($"{names[selection]}'s favorite food is {food[selection]}.");
    }
    else
    {
        Console.WriteLine("Invalid selection.");
    }

    while (true)
    {
        Console.WriteLine("Would you like to learn about another student? y/n");
        string cont = Console.ReadLine().ToLower();
        if (cont == "y")
        {
            runProgram = true;
            break;
        }
        else if (cont == "n")
        {
            Console.WriteLine("Thanks for playing.  Goodbye!");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}





//static int validateInput(int x)
//{
//    Console.WriteLine("Please select a student by number (1-16)");
//    int selection = int.Parse(Console.ReadLine()) - 1;
//    if (selection > 0 || selection <= 16)
//    {
//        return selection
//    }
//    else
//    {
//        Console.WriteLine("Entry invalid. Please try again.");
//    }
//}