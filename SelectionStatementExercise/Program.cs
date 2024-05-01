namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("Let's see if you can guess the correct number");
            Console.WriteLine("Pick a number between 1 and 15");

            var r = new Random();
            var favNumber = r.Next(1, 15);

            Console.WriteLine("Please input your guess.");

            var guess = int.Parse(Console.ReadLine());

            if (guess > favNumber)
            {
                Console.WriteLine("You guessed too high!");
            }
            else if (guess > favNumber)
            {
                Console.WriteLine("Your guess is too low.  Sorry!");
            }
            else
            {
                Console.WriteLine("Correct!  You guessed it!");
            }
        }
    }
}
