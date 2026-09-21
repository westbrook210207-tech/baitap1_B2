class Program4

{
    static void Main2(string[] args)
    {
        //Excercise_1(1,2,3);
        //Excercise_2(2);

    }

    static void Excercise_1(params int []p)
    {
        int maxValue = p.Max();
        System.Console.WriteLine(maxValue);
    }

    static void Excercise_2(int a)
    {
        if (a < 0) throw new ArgumentOutOfRangeException(nameof(a), "Factorial is not defined for negative numbers.");
    
    long result = 1;
    for (int i = 2; i <= a; i++)
    {
        result *= i;
    }
    System.Console.WriteLine(result); 
    }

    static bool Excercise_3(int n)
    {
    if (n <= 1) return false;
    if (n <= 3) return true;
    if (n % 2 == 0 || n % 3 == 0) return false;

    // Check numbers of the form 6k ± 1 up to sqrt(n)
    for (int i = 5; i * i <= n; i += 6)
    {
        if (n % i == 0 || n % (i + 2) == 0)
            return false;
    }

    return true;
    }

    static void Exercise_4_1(int n)
    {
        int dem = 0;
        while (dem < n)
        {
            for (int i = 2; i <= n ; i ++ )
        {
            if (Excercise_3(i))
            {
                System.Console.WriteLine($"{i}, ");
            }
            dem ++;
        }
        }
    }

    
}