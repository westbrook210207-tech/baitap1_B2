class Program
{
    static void Main(string[] args)
    {
        //Exercise1();
        //Exercise2();
        //Exercise3();
        //Exercise4();
        //Exercise5();
        //Exercise6();
        //Exercise7();
        //Exercise8();
        //Exercise9();
        Exercise10();
    }

    static void Exercise1()
    {
        Console.WriteLine("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
    }

    static void Exercise2()
    {
        Console.WriteLine("Enter first variable: ");
        var var1 = Console.ReadLine();
        Console.WriteLine("Enter second variable: ");
        var var2 = Console.ReadLine();
        var temp = var1;
        var1 = var2;
        var2 = temp;
        Console.WriteLine($"After swapping, first variable: {var1}, second variable: {var2}");
    }
    static void Exercise3()
    {
        Console.WriteLine("Enter first number: ");
        float num = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());
        float product = num * num2;
        Console.WriteLine($"The product of {num} and {num2} is: {product}");
    }
    static void Exercise4()
    {
        Console.WriteLine("Enter feet: ");
        float feet = Convert.ToSingle(Console.ReadLine());
        float meters = feet * 0.3048f;
        Console.WriteLine($"{feet} feet is equal to {meters} meters.");
    }
    static void Exercise5()
    {
        Console.WriteLine("Enter Celsius temperature: ");
        float celsius = Convert.ToSingle(Console.ReadLine());
        float fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F.");
        // Now convert back from Fahrenheit to Celsius
        Console.WriteLine("Enter Fahrenheit temperature: ");
        float fahrenheitInput = Convert.ToSingle(Console.ReadLine());
        float celsiusOutput = (fahrenheitInput - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheitInput}°F is equal to {celsiusOutput}°C.");
    }
    static void Exercise6()
    {
        Console.WriteLine($"Size of int: {sizeof(int)} bytes");
        Console.WriteLine($"Size of float: {sizeof(float)} bytes");
        Console.WriteLine($"Size of double: {sizeof(double)} bytes");
        Console.WriteLine($"Size of char: {sizeof(char)} bytes");
        Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");
    }
    static void Exercise7()

    {
        Console.WriteLine("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());
        int asciiValue = (int)ch;
        Console.WriteLine($"The ASCII value of '{ch}' is: {asciiValue}");
    }
    static void Exercise8()
    {
        Console.WriteLine("Enter radius of the circle: ");
        float radius = Convert.ToSingle(Console.ReadLine());
        const float pi = 3.14159f;
        float area = pi * radius * radius;
        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
    }
    static void Exercise9()
    {
        Console.WriteLine("Enter length of the side: ");
        int side = Convert.ToInt32(Console.ReadLine());
        int area = side * side;
        Console.WriteLine($"The area of the square with side {side} is: {area}");
    }
    static void Exercise10()
    {
        Console.WriteLine("Enter days: ");
        int days = Convert.ToInt32(Console.ReadLine());
        float years = days / 365.0f;
        float weeks = days / 7.0f;
        Console.WriteLine($"{days} days is approximately {years} years and {weeks} weeks.");
    }
}
