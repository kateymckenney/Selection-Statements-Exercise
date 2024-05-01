namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {


            //----------------Exercise 1-------------------


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
            else if (guess < favNumber)
            {
                Console.WriteLine("Your guess is too low.  Sorry!");
            }
            else
            {
                Console.WriteLine("Correct!  You guessed it!");
            }



            //---------------Exercise 2------------------

            Console.WriteLine("What is your favorite school subject?");
            string favSub = Console.ReadLine();

            switch (favSub.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is cool because there is always something new to learn!");
            
                    break;

                case "science":
                    Console.WriteLine("Science is great because it encourages us to ask questions, test, and try new things!");

                    break;

                case "geography":
                    Console.WriteLine("Geography helps us appreciate different areas and cultures around the world.");

                    break;

                case "art":
                    Console.WriteLine("Art is a wonderful way to encourage self expression and creativity!");

                    break;

                case "languages":
                    Console.WriteLine("Learninig new languages is one of the best ways to connect with people and cultures different from your own!");

                    break;

                default:
                    Console.WriteLine("Wow, that is one of my favorites too!");

                    break;

            }


        }

    }
}
