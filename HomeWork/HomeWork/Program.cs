using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine();
            Console.WriteLine("TASK 1");

            const int fibLength = 10;
            int[] fibonacciSequence = new int[fibLength];

            fibonacciSequence[0] = 0;
            fibonacciSequence[1] = 1;

            for (int i = 2; i < fibonacciSequence.Length; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 2] + fibonacciSequence[i - 1];
            }

            Console.WriteLine($"Fibonacci first {fibLength} digits:");
            foreach (int digit in fibonacciSequence)
            {
                Console.Write($"{digit} ");
            }
            Console.WriteLine();

            //////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("TASK 2");

            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            //for (int i = 2; i <= 20; i+=2)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();

            //////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("TASK 3");

            for (int i = 1; i <= 5; i++)
            {

                Console.Write("1 x N: \t");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j} \t");
                }
                Console.WriteLine();
            }

            //////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("TASK 4");

            string setPassword = "qwerty";
            Console.WriteLine("What's the password?");
            string userInput = Console.ReadLine();

            //while (userInput != setPassword)
            //{
            //    Console.WriteLine("Incorrect Password");
            //    Console.ReadLine();
            //}

            do
            {
                Console.WriteLine("Incorrect Password");
                Console.ReadLine();
            }
            while (userInput != setPassword);
            

        }
    }
}