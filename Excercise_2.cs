using System.Numerics;
using System.Xml.Schema;

class Program2
{
    static void Main2(string[] args)
    {
        //Exercise1();
        //Exercise2();
        //Exercise3();
        //Exercise4();
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
        float volume = (4 / 3) * 3.14f * radius * radius * radius;
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
        float tieuthu = (SDM - SDC);
        float total_ = 0f;
        Console.WriteLine($"số điện tiêu thụ: {tieuthu}");
        if (tieuthu <= 50)
        {
            total_ = tieuthu * 1860;
        }
        else if (tieuthu <= 100)
        {
            total_ = 50 * 1860 + (tieuthu - 50) * 1866;
        }
        else if (tieuthu <= 200)
        {
            total_ = 50 * 1860 + 50 * 1866 + (tieuthu - 100) * 2167;
        }
        else if (tieuthu <= 300)
        {
            total_ = 50 * 1860 + 50 * 1866 + 100 * 2167 + (tieuthu - 200) * 2729;
        }
        else
        {
            total_ = 50 * 1860 + 50 * 1866 + 100 * 2167 + 100 * 2729 * (tieuthu - 300) * 3050;
        }
        float total = total_ * 1.08f;
        Console.WriteLine($"Tổng tiêu thụ {tieuthu}");
        Console.WriteLine($"Tiền điện chưa thuế {total_}");
        Console.WriteLine($"Tổng tiền {total}");
        Console.WriteLine($"Tiền thuế {total_ * 0.08f}");
    }
}