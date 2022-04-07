// See https://aka.ms/new-console-template for more information
GreetUser();

while (true)
{
    Random randomNumber = new Random();

    int correctNumber = randomNumber.Next(1, 11);
    int guess = 0;

    Console.WriteLine("Guess the number between 1-10:");

    while (guess != correctNumber)
    {
        string input = Console.ReadLine();

        if (!int.TryParse(input, out guess))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter an actual number from 1-10.");
            Console.ResetColor();
            continue;

        }

        guess = Int32.Parse(input);


        if (guess == correctNumber)
        {
            PrintMessage(ConsoleColor.Green, "You are correct!");
        }
        else
        {
            PrintMessage(ConsoleColor.Red, "Try again!");
        }

    }

    Console.WriteLine("Play again? [Y or N]");

    string answer = Console.ReadLine().ToUpper();

    if (answer == "Y")
    {
        continue;
    }
    else
    {
        return;
    }
}

static void PrintMessage(ConsoleColor color, string message)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ResetColor();
}

static void GreetUser()
{
    Console.WriteLine("Welcome to the Guess the Number Game!");
    Console.WriteLine("What's your name?");

    string name = Console.ReadLine();

    Console.WriteLine("Welcome {0} to the game", name);

}

