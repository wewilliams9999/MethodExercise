using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("What is your favorite color?");
            //string favColor = Console.ReadLine();

            //Console.WriteLine("What is your favorite animal?");
            //string favAnimal = Console.ReadLine();

            //Console.WriteLine("What is your favorite band?");
            //string favBand = Console.ReadLine();

            //Console.WriteLine($"There was a boy named {userName} whose favorite color was {favColor}.");
            //Console.WriteLine($"He loved {favAnimal} and going to {favBand} concerts.");

            Console.WriteLine("Give me a number to add, please");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the 1st one, please");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 2,3,5,7);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number, please");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply with the 1st one, please");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

            //Subtract
            Console.WriteLine("Give me a number, please");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract from the 1st one, please");
            num2 = int.Parse(Console.ReadLine());

            int whatsLeft = Subtract(num1, num2);
            Console.WriteLine($"The result is: {whatsLeft}");

            //Divide
            Console.WriteLine("Give me a number, please");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide the 1st number by, please");
            num2 = int.Parse(Console.ReadLine());

            int result = Divide(num1, num2);
            Console.WriteLine($"The result is: {result}");

            //Modulus
            Console.WriteLine("Give me a number, please");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide the 1st number by, please. I'll show you the remainder");
            num2 = int.Parse(Console.ReadLine());

            int remainder = Modulus(num1, num2);
            Console.WriteLine($"The result is: {remainder}");
        }

        public static int Sum(params int[] list)
        {
            int sum = 0;

            for(int i= 0; i < list.Length; i++)
            {
                sum = sum + list[i]; 
            }
            return sum;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Divide(int c, int d)
        {
            return c / d;
        }

        public static int Modulus(int e, int f)
        {
            return e % f;
        }
    }
}
