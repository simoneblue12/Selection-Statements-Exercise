namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 5;
            int userInput = 0;

            //Keep looping until the user guesses the correct number
            while (userInput != favNumber)
            {
                Console.WriteLine("Guess my favorite number:");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"Too low!\nYour guess: {userInput}");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"Too high!\nYour Guess: {userInput}");
                }
                else
                {
                    Console.WriteLine($"You guessed it!!!\nThe favorite number was {favNumber}!");
                }
            }
        }
    }
}
