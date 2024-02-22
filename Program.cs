namespace Casting_Null_Asher
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Hello, World!");

            // Prompts the user to enter their favorite number
            Console.WriteLine("Enter your favorite Number!:");

            // Reads user input from the console, converts it to an integer, and assigns it to the variable favoriteNumber
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());

            // Prints the user's favorite number
            Console.WriteLine("Your Favorite Number Is " + favoriteNumber);

            // Asks the user if they have a dog and expects a True or False response
            Console.WriteLine("Do you have a dog? Answer True or False");

            // Reads user input from the console, converts it to a boolean value, and assigns it to the variable isTrue
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            // Prints a message indicating whether the user has a dog based on the boolean value
            Console.WriteLine("It is " + isTrue + " that I have a dog!");




        }
    }
}