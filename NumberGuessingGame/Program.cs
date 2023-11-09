// declare local variables
Random rand = new Random();

int winningNumber = rand.Next(0, 100);

bool hasWon = false;

// allow user to guess until the get it right
do
{
    Console.Write("Guess a number between 0 and 100: ");
    string readResult = Console.ReadLine();

    int guessNumber = int.Parse(readResult);

    if (guessNumber > winningNumber)
        Console.WriteLine("Too high! Guess lower...");
    else if (guessNumber < winningNumber)
        Console.WriteLine("Too Low! Guess higher...");
    else
    {
        Console.WriteLine("YOU WIN!!");
        hasWon = true;
    }

    Console.WriteLine();        
} while (hasWon == false);

Console.WriteLine("Thank you for playing this game.");
Console.WriteLine("Press any key to finish.");
Console.ReadKey();