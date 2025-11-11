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

        //Console.WriteLine("Enter operation");
        //Console.WriteLine("& - for bitwise AND");
        //Console.WriteLine("| - for bitwise OR");
        //Console.WriteLine("^ - for bitwise XOR");

        
        Console.WriteLine("1 - for bitwise AND");
        Console.WriteLine("2 - for bitwise OR");
        Console.WriteLine("3 - for bitwise XOR");

        var operation = Console.ReadLine();

        if (operation == null || operation.Length == 0 || operation.Length > 1)
        {
            Console.WriteLine("Wrong operation");
            return;
        }


        int decimalResult, binaryResult, hexResult;

        switch (operation[0])
        {
            case '1':
                decimalResult = number1 & number2;
                binaryResult = number2 & number1;
                hexResult = number1 & number2;
                break;
            case '2':
                decimalResult = number1 | number2;
                binaryResult = number1 | number2;
                hexResult = number1 | number2;
                break;
            case '3':
                decimalResult = number1 ^ number2;
                binaryResult = number1 ^ number2;
                hexResult = number1 ^ number2;
                break;
            default:
                Console.WriteLine("Wrong operation, only &, | or ^ possible");
                return;
        }

        Console.WriteLine("decimal: " + Convert.ToString(decimalResult, 10));
        Console.WriteLine("binary: " + Convert.ToString(binaryResult, 2));
        Console.WriteLine("hexadecimal: " + Convert.ToString(hexResult, 16));
    
        }

    }
