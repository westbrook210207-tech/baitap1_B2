class Program2
{
    static void Main(string[] args)
    {
        //Exercise1();
        //Exercise2();
        //Exercise3();
        Exercise4();
    }
    static void Exercise1()
        {
        Console.WriteLine("Enter Celsius temperature: ");
        float celsius = Convert.ToSingle(Console.ReadLine());
        float fahrenheit = (celsius * 9 / 5) + 32;
        float kelvin = celsius + 273.15f;
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F and {kelvin}K.");
        }
    static void Exercise2()
    {
        Console.WriteLine("Enter radius of the sphere: ");
        float radius = Convert.ToSingle(Console.ReadLine());
        float surfaceArea = 4 * 3.14f * radius * radius; 
        float volume = (4/3) * 3.14f * radius * radius * radius;
        Console.WriteLine($"Surface area of the sphere: {surfaceArea}");
        Console.WriteLine($"Volume of the sphere: {volume}");
    }
    static void Exercise3()
    {
        Console.WriteLine("Enter the first number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");
        Console.WriteLine($"Division: {num1 / num2}");
        Console.WriteLine($"Modulus: {num1 % num2}");
    }
    static void Exercise4()
    {
        Console.WriteLine("nhập số điện cũ: ");
        float SDC = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("nhập số điện mới: ");
        float SDM = Convert.ToSingle(Console.ReadLine());
        bool check = SDM > SDC;
        if (!check)
        {
            Console.WriteLine("số điện mới phải lớn hơn số điện cũ");
            return;
        }
        float total = (SDM - SDC);
        Console.WriteLine($"số điện tiêu thụ: {total}");
        if (total <= 50)
        {
            Console.WriteLine($"số tiền phải trả: {total * 1860}");
        }
        else if (total <= 100)
        {
            Console.WriteLine($"số tiền phải trả: {50 * 1860 + (total - 50) * 1866}");
        }
        else if (total <= 200)
        {
            Console.WriteLine($"số tiền phải trả: {50 * 1860 + 50 * 1866 + (total - 100) * 2167}");
        }
        else
        {
            Console.WriteLine($"số tiền phải trả: {50 * 1860 + 50 * 1866 + 100 * 2167 + (total - 200) * 2729}");
        }
    }
}