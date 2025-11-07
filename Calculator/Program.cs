class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number");
        if (!Int32.TryParse(Console.ReadLine(), out var number1))
        {
            Console.WriteLine("Not a number");
            return;
        }

        Console.WriteLine("Enter second number");
        if (!Int32.TryParse(Console.ReadLine(), out var number2))
        {
            Console.WriteLine("Not a number");
            return;
        }

        Console.WriteLine("Enter a sign &, | or ^");
        var sign = Console.ReadLine();
        var boolSign = true;
        if (sign.Length == 0 || sign.Length > 1 && !boolSign)
        {
            Console.WriteLine("Wrong sign");
            return;
        }

        switch (sign[0])
        {
            case '&':
                // Console.WriteLine("Result of {0} + {1} = {2}", number1 & number2);
                  Console.WriteLine(Convert.ToString(number1 & number2, 10));
                  Console.WriteLine(Convert.ToString(number1 & number2, 2));
                  Console.WriteLine(Convert.ToString(number1 & number2, 16));
                break;
            case '|':
                // Console.WriteLine("Result of {0} + {1} = {2}", number1 | number2);
                Console.WriteLine(Convert.ToString(number1 | number2, 10));
                Console.WriteLine(Convert.ToString(number1 | number2, 2));
                Console.WriteLine(Convert.ToString(number1 | number2, 16));
                break;
            case '^':
                // Console.WriteLine("Result of {0} + {1} = {2}", number1 ^ number2);
                Console.WriteLine(Convert.ToString(number1 ^ number2, 10));
                Console.WriteLine(Convert.ToString(number1 ^ number2, 2));
                Console.WriteLine(Convert.ToString(number1 ^ number2, 16));
                break;
            default:
                Console.WriteLine("Wrong sign");
                return;
        }
    }
}
