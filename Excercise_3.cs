using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program3

{
    static void Main3(string[] args)
    {
        //Exercise1();
        //Excercise_2();
        //Excercise_3();
        //Excercise_4();
        
    }
    static void Excercise_1()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is Even.");
        }
        else
        {
            Console.WriteLine(number + " is Odd.");
        }
    }
    static void Excercise_2()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("Largest number is: " + a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("Largest number is: " + b);
        }
        else
        {
            Console.WriteLine("Largest number is: " + c);
        }
    }
    static void Excercise_3()
    {
        Console.Write("Enter side 1: ");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side 2: ");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter side 3: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }

    static void Excercise_4()
    {
        Console.Write("Enter X coordinate: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("The point is at the Origin.");
        }
        else if (x == 0)
        {
            Console.WriteLine("The point lies on the Y-axis.");
        }
        else if (y == 0)
        {
            Console.WriteLine("The point lies on the X-axis.");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("The point lies in Quadrant I.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point lies in Quadrant II.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point lies in Quadrant III.");
        }
        else
        {
            Console.WriteLine("The point lies in Quadrant IV.");
        }
    }
    static void Excercise_5()
    {
        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Case a = 0 -> not actually a quadratic equation
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("The equation has infinite solutions.");
                }
                else
                {
                    Console.WriteLine("The equation has no solution.");
                }
            }
            else
            {
                // Linear equation: bx + c = 0
                double x = -c / b;
                Console.WriteLine("This is a linear equation, solution: x = " + x);
            }
        }
        else
        {
            // Calculate delta (discriminant)
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("The equation has 2 distinct roots:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equation has a double root: x = " + x);
            }
            else
            {
                Console.WriteLine("The equation has no real solution (delta < 0).");
            }
        }
    }
}
