using System;

namespace MethodsClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you ?");
            string age = Console.ReadLine();

            Console.WriteLine("what is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("what is your favorite Color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine($"There was a girl named {userName}, She was {age} years old.");
            Console.WriteLine($"Her favorite animals are {favoriteAnimal}, and favorite color is {favoriteColor}.");
            Console.WriteLine($"{userName} espically loved {favoriteColor} colored {favoriteAnimal}.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number to multiply");
             num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
             num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

        }

        public static int Sum(params int[] list )
        {
            int sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
           
            }



        public static int Multiply(int x, int y)
        {
            return x * y;
               
        }

    }
}
          
        
        

