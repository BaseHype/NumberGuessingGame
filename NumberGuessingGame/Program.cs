// declare local variables
using System.Security.AccessControl;

Random rand = new Random();
int selectedLevel;
int winningNumber;
int guessNumber;

bool retryTurn = false;

// repeat until user exits
do
{
    bool hasWon = false;
    bool levelValid = false;

    // user selects level of difficulty
    do
    {
        Console.Write("Select Your Level of Difficulty: ");
        string readLevel = Console.ReadLine();

        selectedLevel = int.Parse(readLevel);

        if (selectedLevel > 0 && selectedLevel <= 10)
        {
            Console.WriteLine($"You have selected level {selectedLevel} difficulty.");
            levelValid = true;
        }

        Console.WriteLine();
    } while (levelValid == false);

    // determine guessing range and select winning number
    int maxRange = selectedLevel * 10;
    winningNumber = rand.Next(0, maxRange);


    // prompt user to guess until they are correct
    do
    {
        Console.Write($"Guess a number between 0 and {maxRange}: ");
        string readResult = Console.ReadLine();

        guessNumber = int.Parse(readResult);

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

    // prompt user to see if they want to continue
    Console.WriteLine("Well done! If you wish to continue type \"Y\" else \"N\"");
    string confirmation = Console.ReadLine();

    retryTurn = confirmation.ToUpper().Trim() == "Y";

} while (retryTurn == true);

// display end game message
Console.WriteLine("Thank you for playing this game.");
Console.WriteLine("Press any key to finish.");
Console.ReadKey();