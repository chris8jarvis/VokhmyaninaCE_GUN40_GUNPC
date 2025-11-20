namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("TASK 1");

            const int fibLength = 8;
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
                Console.WriteLine($"{digit} ");
            }
            //////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("TASK 2");

            string[] YearMonths = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "Novemer", "December" };

            foreach (string month in YearMonths)
            {
                Console.WriteLine(month);
            }
            /////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("TASK 3");

            int[,] matrix = new int[3, 3] {
        { (int)Math.Pow(2,1), (int)Math.Pow(3,1), (int)Math.Pow(4,1) },
        { (int)Math.Pow(2,2), (int)Math.Pow(3,2), (int)Math.Pow(4,2) },
        { (int)Math.Pow(2,3), (int)Math.Pow(3,3), (int)Math.Pow(4,3) }
    };
            Console.WriteLine("Двумерный массив 3x3:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            ///////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("TASK 4");

            double[][] jaggedArray = new double[3][];
            jaggedArray[0] = new double[5] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new double[2] { Math.PI, Math.E };
            jaggedArray[2] = new double[4] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

            Console.WriteLine("Jagged array:");
            foreach (double[] arr in jaggedArray)
            {
                foreach (double element in arr)
                {
                    Console.Write($"{element.ToString("F2")}\t");
                }
                Console.WriteLine();
            }

            // alternative version.
            //double[][] jaggedArray = new double[3][];
            //jaggedArray[0] = new double[5];
            //jaggedArray[1] = new double[2];
            //jaggedArray[2] = new double[4];

            //// заполняем первую строку
            //for (int i = 0; i < 5; i++)
            //{
            //    jaggedArray[0][i] = i + 1;
            //    Console.Write("{0}\t", jaggedArray[0][i]);
            //}
            //Console.WriteLine();

            //// заполняем вторую строку
            //jaggedArray[1][0] = Math.PI;
            //Console.Write("{0}\t", jaggedArray[1][0].ToString("F2"));
            //jaggedArray[1][1] = Math.E;
            //Console.Write("{0}\t", jaggedArray[1][1].ToString("F2"));
            //Console.WriteLine();

            //// заполняем третью строку
            //for (int i = 0; i < jaggedArray[2].Length; i++)
            //{
            //    jaggedArray[2][i] = Math.Log10(Math.Pow(10, i));
            //    Console.Write("{0}\t", jaggedArray[2][i]);
            //}
            //Console.WriteLine();


            ///////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("TASK 5");

            int[] FirstArray = { 1, 2, 3, 4, 5 };
            int[] SecondArray = { 7, 8, 9, 10, 11, 12, 13 };

            System.Array.Copy(FirstArray, SecondArray, 3);

            foreach (int digit in SecondArray)
            {
                Console.Write($"{digit}\t");
            }
            //////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("TASK 6");

            Array.Resize(ref FirstArray, FirstArray.Length + 5);
            for (int i = 0; i < FirstArray.Length; i++)
            {
                Console.WriteLine("[{0}] : {1}", i, FirstArray[i]);
            }
        }
    }
}
