Console.Write("What is your name?: ");
string userName = Console.ReadLine();
bool keepGoing = true;
while (keepGoing == true)
{
    Console.Write($"{userName}, please enter an integer between 1 and 100: ");
    string userInput = Console.ReadLine();
    int userInt = Convert.ToInt32(userInput);
    if (userInt >= 1 && userInt <= 100)
    {
        if (userInt % 2 != 0 && userInt < 60)
        {
            Console.WriteLine($"{userInt} is odd and less than 60.");
        }
        else if (userInt % 2 == 0 && userInt <= 24 && userInt >= 2)
        {
            Console.WriteLine($"{userInt} is even and less than 25.");
        }
        else if (userInt % 2 == 0 && userInt <= 60 && userInt >= 26)
        {
            Console.WriteLine($"{userInt} is even and between 26 and 60 inclusive.");
        }
        else if (userInt % 2 == 0 && userInt > 60)
        {
            Console.WriteLine($"{userInt} is even and greater than 60.");
        }
        else if (userInt % 2 != 0 && userInt > 60)
        {
            Console.WriteLine($"{userInt} is odd and greater than 60.");
        }
        else
        {
            Console.WriteLine("I don't know how you got here, this isn't possible.");
        }
        Console.Write($"Do you want to do it again, {userName}? (y/n): ");
        string answer = Console.ReadLine().ToLower();
        if (answer == "n")
        {
            keepGoing = false;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nThat is not an integer between 1 and 100. Try Again.\n");
        Console.ResetColor();
    }
}