using System.Reflection.Metadata.Ecma335;

class Program3

{
    static void Main(string[] args)
    {
        //Exercise1();
        //Excercise_2();
        //Excercise_3();
        //Excercise_4();
        Excercise_5();
    }
    static void Excercise_1()
    {
        Console.WriteLine("Hãy nhập 1 số a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Hãy nhập 1 số b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"{a} + {b} = {a+b}");
        Console.WriteLine($"{a} - {b} = {a-b}");
        Console.WriteLine($"{a} * {b} = {a*b}");
        Console.WriteLine($"{a} / {b} = {a/b}");
        Console.WriteLine($"{a} % {b} = {a%b}");
    }
    static void Excercise_2()
    {
        double y;

        // Prompt user and parse float/double input
        Console.Write("Please enter a number from -5 to 5: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Please enter a valid number: ");
        }

        while (true)
        {
            if (y >= -5 && y <= 5)
            {
                // Math equation: x = y^2 + 2y + 1
                double x = Math.Pow(y, 2) + (2 * y) + 1;
                Console.WriteLine(x);
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number: ");
                Console.Write("Please enter a number from -5 to 5: ");
                
                // Re-prompt until they provide a valid number
                while (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Please enter a valid number: ");
                }

    }
        }
}
    static void Excercise_3()
    {
        Console.WriteLine("Enter Distance traveled in km: "); float distance = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Time traveled in hours: "); float time = float.Parse(Console.ReadLine());
        Console.WriteLine($"Your speed is {distance/time} km/h");
        Console.WriteLine($"Your speed is {distance*0.621371f/time} mile/h");
    }
    static void Exercise_4()
    {
        Console.WriteLine("Enter radius of the sphere: ");
        float radius = Convert.ToSingle(Console.ReadLine());
        float surfaceArea = 4 * 3.14f * radius * radius; 
        float volume = (4/3) * 3.14f * radius * radius * radius;
        Console.WriteLine($"Surface area of the sphere: {surfaceArea}");
        Console.WriteLine($"Volume of the sphere: {volume}");
    }

    static void Excercise_5()
    {
        Console.WriteLine("Enter anything: ");
        string symbol = Console.ReadLine();
        string[] vowels = { "u", "i", "e", "o", "a" };

        if (vowels.Contains(symbol.ToLower()))
        {
            Console.WriteLine($"{symbol} is a vowel");
        }
        else if (int.TryParse(symbol, out int number) && number >= 0 && number <= 9) 
        {
            // Checks if the input is a single digit/number (0-9)
            Console.WriteLine($"{symbol} is a digit");
        }
        else
        {
            Console.WriteLine($"{symbol} is other symbol");
        }
    }
    }
    