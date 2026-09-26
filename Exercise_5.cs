using System;
using System.Security.Cryptography;

class Program2
{
    static void Main(string[] args)
    {
        int result = TinhTong(a: 1, b: 2);
        System.Console.WriteLine(result);
        
        bool results2 = KiemTraChan(n:1);
        System.Console.WriteLine(results2);

        int result3 = TimMax(a:1, b:2, c:7);
        System.Console.WriteLine(result3);

        long result4 = TinhGiaiThua(5);
        System.Console.WriteLine(result4);

        string result5 = DaoNguocChuoi("foo");
        System.Console.WriteLine(result5);

        bool result6 = KiemTraNguyenTo(n:23);
        System.Console.WriteLine(result6);

        InFibonacci(10);

        int result8 = DemNguyenAm("cucurelaa");
        System.Console.WriteLine(result8);

        double result9 = TinhLuyThua(x:2d,y:3);
        System.Console.WriteLine(result9);

        double result10 = TinhTrungBinh([1,2,3,4,5]);
        System.Console.WriteLine(result10);

        bool result11 = KiemTraDoiXung("anna");
        System.Console.WriteLine(result11);

        double result12 = CelsiusToFahrenheit(0d);
        System.Console.WriteLine(result12);

        int result13 = TimMin([1,2,3,4,0]);
        System.Console.WriteLine(result13);

        int result14 = TongCacChuSo(1234);
        System.Console.WriteLine(result14);

        SapXepMang([1,5,4,3,6]);

        string result16 = XoaTrungLap("Programming");
        System.Console.WriteLine(result16);

        int result17 = UCLN(12,16);
        System.Console.WriteLine(result17);

        string result18 = DecimalToBinary(10);
        System.Console.WriteLine(result18);

        bool result19 = KiemTraNamNhuan(2016);
        System.Console.WriteLine(result19);

        int result20 = DemSoTu("Học lập trình C# rất thú vị");
        System.Console.WriteLine(result20);
    }

    static int TinhTong(int a, int b)
    {
        return a+b;
    }

    static bool KiemTraChan(int n)
    {
        if (n % 2 == 0)
        {
            return true;
        }
        return false;
    }

    static int TimMax(int a, int b, int c)
    {
        return Math.Max(Math.Max(a, b), c);
    }

    static long TinhGiaiThua(int n)
    {
        long res = 1;
        for (int i = n; i>0; i-- )
        {
            res *= i;
        }
        return res;
    }

    static string DaoNguocChuoi(string input)
    {
        char[] charArray = input.ToCharArray(); 

        Array.Reverse(charArray); 

        string reversed = new string(charArray);
        return reversed;
    }

    static bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;
    
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0) return false;
    }
    
    return true;
    }

    static void InFibonacci(int n)
    {
        long[] fib = new long[n];
        fib[0] = 0;
        fib[1] = 1;
        System.Console.WriteLine(fib[0]);
        System.Console.WriteLine(fib[1]);
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
            System.Console.WriteLine(fib[i]);
        }
    }

    static int DemNguyenAm(string s)
        {
            int dem = 0;
            string nguyenAm = "aeiouAEIOU";
            foreach (char letter in s)
            {
                if (nguyenAm.Contains(letter))
                {
                    dem ++;
                }
            }
            return dem;
        }

    static double TinhLuyThua(double x, int y)
    {
    double res = 1;
    for (int i = 0; i < Math.Abs(y); i++)
    {
        res *= x;
    }
    return res;
    }

    static double TinhTrungBinh(int[] arr)
    {
        double res = arr.Sum()/arr.Length;
        return res;
    }

    static bool KiemTraDoiXung(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray); 
        string reversed = new string(charArray);

        if (reversed == s)
        {
            return true;
        }
        return false;
    }

    static double CelsiusToFahrenheit(double c)
    {
        double res = c*(9.0/5.0)+32;
        return res;
    }

    static int TimMin(int[] arr)
    {
        return arr.Min();
    }

    static int TongCacChuSo(int n)
    {
        int positiveNum = Math.Abs(n);
        string str = positiveNum.ToString();
        char[] charArray = str.ToCharArray();
        int sum = 0;

        for (int i = 0; i < charArray.Length; i++)
        {
            // Turn individual char back into a string since int.Parse only accept string not char
            string singleCharString = charArray[i].ToString();

            int digit = int.Parse(singleCharString);
            sum += digit;
        }

        return sum;
    
    }

    static void SapXepMang(int[] arr)
    {
        Array.Sort(arr);
        foreach(int i in arr)
        {
            System.Console.WriteLine(i);
        }
    }

    static string XoaTrungLap(string s)
    {
        string uniqueString = new string(s.Distinct().ToArray());
        return uniqueString;

    }

    static int UCLN(int a, int b)
    {
        while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
    }

    static string DecimalToBinary(int n)
    {
        string binary = Convert.ToString(n, 2); // built-in binary transformating func
        return binary;
    }

    static bool KiemTraNamNhuan(int year)
    {
        if (year % 4 ==0)
        {
            return true;
        }
        return false;
    }

    static int DemSoTu(string sentence)
    {
        string[] split_word = sentence.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        int num_word = split_word.Length;
        return num_word;
    }
}
