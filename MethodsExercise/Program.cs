

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer; }

        
       
        
        

        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;


        }
        public static int Divide(int num1, int num2)
            {
                return num1 / num2 ;
            }

        public static int modulus(int num1, int num2)
        { return num1 % num2 ; }

        static void Main(string[] args)
        {
            var amountOfBalls = Sum(2, 6);
            var toys = Multiply(60, 2, 4);
                var shoes = Subtract(50, 25);
                var clothes = Divide(50, 25);
            var cups = modulus(10, 3);
            

            Console.WriteLine(amountOfBalls);
            Console.WriteLine(toys);
                Console.WriteLine(shoes);
                Console.WriteLine(clothes);
            Console.WriteLine(cups);
               

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
            //------------------exercise 2------------------
          

        }
    }

}


