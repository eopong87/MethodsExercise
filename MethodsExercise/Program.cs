

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //-------Exercise 1--------
            // Name: Eddie
            // Favorite Color: Red
            // Favorite Animal: Tiger
            // Favorite Band: Wu-Tang Clan

            Console.WriteLine("Hello- What is your name?");
            var username = Console.ReadLine();

            Console.WriteLine($"Hi, {username}.  what is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine(" Thats cool! Who is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Name:{username}");
            Console.WriteLine($"We saw a {color} {animal} walking down the street");
            Console.WriteLine($"The big {animal} roared at us as we ran across the street.");
            Console.WriteLine($"we noticed he was listening to {band}.");
            Console.ReadLine();
        }
    }
}



