public static class Services
{
    public static int GetValidNumber(string inputValue)
    {
        int number;
        do
        {
            Console.WriteLine(inputValue);
            string input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                break;
            }
            else
            {
                Console.WriteLine("Input is not a valid number. Please enter a valid integer.");
            }
        } while (true);

        return number;
    }
    public static void Calculate(int a, int b, string letter)
    {
        int result = 0;
        switch (letter)
        {
            case "a":
                System.Console.WriteLine($"{a} + {b} = " + (a + b));
                break;
            case "s":
                System.Console.WriteLine($"{a} + {b} = " + (a - b));
                break;
            case "m":
                System.Console.WriteLine($"{a} + {b} = " + (a * b));
                break;
            case "d":
                if (b == 0)
                {
                    System.Console.WriteLine("It is impossible to divide by 0");
                }
                else
                {
                    System.Console.WriteLine($"{a} + {b} = " + (a / b));
                }
                break;
            default:
                System.Console.WriteLine("Invalid option");
                break;
        }
    }
    public static void exitApp()
    {
        System.Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
}