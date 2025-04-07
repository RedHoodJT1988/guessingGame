namespace guessingGame;

class Program
{
    static void Main(string[] args)
    {
        var guesses = 3;
        Console.Title = "Guessing Game";
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("You have 3 guesses to find the number between 1 and 20.");
        Console.WriteLine("Press any key to start...");
        Console.ReadKey();
        Console.Clear();
        Random random = new Random();
        int numberToGuess = random.Next(1, 21);
        bool guessedCorrectly = false; 
        while (guesses > 0 && !guessedCorrectly)
        {
            Console.WriteLine($"You have {guesses} guesses left.");
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int userGuess))
            {
                if (userGuess < 1 || userGuess > 20)
                {
                    Console.WriteLine("Please enter a number between 1 and 20.");
                }
                else if (userGuess == numberToGuess)
                {
                    guessedCorrectly = true;
                    Console.WriteLine("Congratulations! You guessed the correct number!");
                }
                else
                {
                    guesses--;
                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else
                    {
                        Console.WriteLine("Too high!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        if (!guessedCorrectly)
        {
            Console.WriteLine($"Sorry, you've run out of guesses. The correct number was {numberToGuess}.");
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Thank you for playing!");
        Console.WriteLine("Goodbye!");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("This program was created by Jonathan Reeves.");
        Console.WriteLine("If you have any questions or feedback, please contact me at [Your Email].");
        Console.WriteLine("You can also find me on GitHub at [Your GitHub].");
        Console.WriteLine("Thank you for your support!");
        Console.WriteLine("This program is licensed under the MIT License.");
        Console.WriteLine("You are free to use, modify, and distribute this program as long as you include this notice.");
        Console.WriteLine("This program is provided 'as is' without warranty of any kind.");
        Console.WriteLine("In no event shall the author be liable for any damages arising from the use of this program.");
        Console.WriteLine("Thank you for your understanding!");
        Console.WriteLine("This program was created for educational purposes.");
        Console.WriteLine("If you would like to learn more about programming, please visit [Your Website].");
        Console.WriteLine("You can also find many resources and tutorials online.");
        Console.WriteLine("I hope you enjoyed this program and learned something new.");
        Console.WriteLine("If you have any suggestions for improvements or new features, please let me know.");
        Console.WriteLine("I would love to hear your feedback and ideas.");
        Console.WriteLine("Thank you for your time and attention!");
        Console.WriteLine("Have a great day!");
        Console.WriteLine("This program was created using C# and .NET.");
        Console.WriteLine("If you would like to learn more about C# and .NET, please visit the official documentation.");
        Console.WriteLine("You can also find many tutorials and courses online.");
        Console.WriteLine("I hope you enjoyed this program and learned something new.");
        Console.WriteLine("If you have any questions or feedback, please contact me.");
        Console.WriteLine("I would love to hear your thoughts and suggestions.");
        Console.WriteLine("Thank you for your support!");
        Console.WriteLine("This program was created using Visual Studio.");
    }
}
