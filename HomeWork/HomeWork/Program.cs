using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            // alternative solution
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

                Console.Write($"x{i}:");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"\t{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }


            //////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("TASK 4");

            string passWord = "qwerty";
            Console.WriteLine("What's the password?");
            string userInput;
            bool passwordAccurate = false;

            do
            {
                userInput = Console.ReadLine();

                if (userInput != passWord)
                {
                    Console.WriteLine("Incorrect password");
                    continue;
                } 
                passwordAccurate = true;
                Console.WriteLine("Correct password");
            }
            while (!passwordAccurate);
        }
    }
}