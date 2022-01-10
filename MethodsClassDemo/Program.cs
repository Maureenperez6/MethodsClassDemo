using System;

namespace MethodsClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
           string name = Console.ReadLine();

            Console.WriteLine("what is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine("what is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("what is your favorite Color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine($"There was a girl named {name}, her favorite band is {band}.");
            Console.WriteLine($"Her favorite animals are {favoriteAnimal}, and favorite color is {favoriteColor}.");
            Console.WriteLine($"{name} espically loved {favoriteColor} colored {favoriteAnimal}.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"the sum is: {sum}");

            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = multiply(num1, num2);
            Console.WriteLine($"the product is: {product}");
        }


        public static int Sum(int num1, int num2)
        { 
            int sum = num1 + num2;
            return sum;
           
             
        }
        public static int multiply(int x, int y)
        {
            return x * y; 
        }

    }
}
          
        
        

