using System.Numerics;
using System.Xml.Schema;

/*class Program2
{
    static void Main3(string[] args)
    {
        //Excercise1();
        //Excercise2();
        //Excercise3();
        //Excercise4();
        //Excercise5();
        //Excercise6();
        //Excercise7();
        //Excercise8();
    }
    static void Excercise1()
    {
        Console.WriteLine("Enter Celsius temperature: ");
        float celsius = Convert.ToSingle(Console.ReadLine());
        float fahrenheit = (celsius * 9 / 5) + 32;
        float kelvin = celsius + 273.15f;
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F and {kelvin}K.");
    }
    static void Excercise2()
    {
        Console.WriteLine("Enter radius of the sphere: ");
        float radius = Convert.ToSingle(Console.ReadLine());
        float surfaceArea = 4 * 3.14f * radius * radius;
        float volume = (4 / 3) * 3.14f * radius * radius * radius;
        Console.WriteLine($"Surface area of the sphere: {surfaceArea}");
        Console.WriteLine($"Volume of the sphere: {volume}");
    }
    static void Excercise3()
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
    static void Excercise4()
    {
        Console.Write("Nhap chi so dien cu (kWh): ");
        decimal chiSoCu = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Nhap chi so dien moi (kWh): ");
        decimal chiSoMoi = Convert.ToDecimal(Console.ReadLine());

        if (chiSoMoi < chiSoCu)
        {
            Console.WriteLine("Loi: Chi so moi phai lon hon hoac bang chi so cu!");
            return;
        }

        decimal soDien = chiSoMoi - chiSoCu;
        decimal soDienConLai = soDien;
        decimal tienDien = 0;

        // Bac 1: 50 kWh dau tien
        decimal bac1 = Math.Min(soDienConLai, 50);
        tienDien += bac1 * 1806;
        soDienConLai -= bac1;

        // Bac 2: 50 kWh tiep theo
        if (soDienConLai > 0)
        {
            decimal bac2 = Math.Min(soDienConLai, 50);
            tienDien += bac2 * 1866;
            soDienConLai -= bac2;
        }

        // Bac 3: 100 kWh tiep theo
        if (soDienConLai > 0)
        {
            decimal bac3 = Math.Min(soDienConLai, 100);
            tienDien += bac3 * 2167;
            soDienConLai -= bac3;
        }

        // Bac 4: 100 kWh tiep theo
        if (soDienConLai > 0)
        {
            decimal bac4 = Math.Min(soDienConLai, 100);
            tienDien += bac4 * 2729;
            soDienConLai -= bac4;
        }

        // Bac 5: tu 301 kWh tro len
        if (soDienConLai > 0)
        {
            tienDien += soDienConLai * 3050;
        }

        decimal thueVAT = tienDien * 8 / 100;
        decimal tongTien = tienDien + thueVAT;

        Console.WriteLine();
        Console.WriteLine("So dien tieu thu: " + soDien + " kWh");
        Console.WriteLine("Tien dien chua thue: " + tienDien.ToString("N0") + " VND");
        Console.WriteLine("Thue VAT (8%): " + thueVAT.ToString("N0") + " VND");
        Console.WriteLine("Tong thanh toan: " + tongTien.ToString("N0") + " VND");
    }
    static void Excercise5()
    {
        Console.Write("Chieu cao (m): ");
        double chieuCao = Convert.ToDouble(Console.ReadLine());

        Console.Write("Can nang (kg): ");
        double canNang = Convert.ToDouble(Console.ReadLine());

        double bmi = canNang / (chieuCao * chieuCao);

        string phanLoai;
        if (bmi < 18.5)
        {
            phanLoai = "Gay (Thieu can)";
        }
        else if (bmi < 23.0)
        {
            phanLoai = "Binh thuong (Ly tuong)";
        }
        else if (bmi < 25.0)
        {
            phanLoai = "Thua can (Tien beo phi)";
        }
        else
        {
            phanLoai = "Beo phi";
        }

        double canNangToiThieu = 18.5 * chieuCao * chieuCao;
        double canNangToiDa = 22.9 * chieuCao * chieuCao;

        Console.WriteLine();
        Console.WriteLine("Chi so BMI cua ban: " + bmi.ToString("F2"));
        Console.WriteLine("Phan loai suc khoe: " + phanLoai);
        Console.WriteLine("Khuyen dung: Can nang ly tuong cua ban nen tu " + canNangToiThieu.ToString("F2") + " kg den " + canNangToiDa.ToString("F2") + " kg.");
    }

    // Excercise 6
    enum CurrencyType
    {
        USD,
        EUR,
        JPY,
        GBP
    }

    static void Exercise6()
    {
        decimal tyGiaUSD = 25400;
        decimal tyGiaEUR = 27200;
        decimal tyGiaJPY = 165;
        decimal tyGiaGBP = 32100;

        Console.Write("Nhap so tien VND: ");
        decimal soTienVND = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Chon ngoai te (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
        int luaChon = Convert.ToInt32(Console.ReadLine());

        decimal tyGia;
        string kyHieu;

        switch (luaChon)
        {
            case 1:
                tyGia = tyGiaUSD;
                kyHieu = "USD";
                break;
            case 2:
                tyGia = tyGiaEUR;
                kyHieu = "EUR";
                break;
            case 3:
                tyGia = tyGiaJPY;
                kyHieu = "JPY";
                break;
            case 4:
                tyGia = tyGiaGBP;
                kyHieu = "GBP";
                break;
            default:
                Console.WriteLine("Lua chon khong hop le!");
                return;
        }

        decimal phiDichVu = soTienVND * 0.5m / 100;
        decimal soTienVNDThucTe = soTienVND - phiDichVu;
        decimal soTienNgoaiTe = soTienVNDThucTe / tyGia;

        Console.WriteLine();
        Console.WriteLine("Phi dich vu (0.5%): " + phiDichVu.ToString("N0") + " VND");
        Console.WriteLine("So tien VND tinh doi: " + soTienVNDThucTe.ToString("N0") + " VND");
        Console.WriteLine("So tien " + kyHieu + " nhan duoc: " + soTienNgoaiTe.ToString("F2") + " " + kyHieu);
    }
    static void Excercise7()
    {
        Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
        string chuoiNgaySinh = Console.ReadLine();

        DateTime ngaySinh;
        bool hopLe = DateTime.TryParseExact(chuoiNgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh);

        if (!hopLe)
        {
            Console.WriteLine("Ngay sinh khong dung dinh dang!");
            return;
        }

        DateTime homNay = DateTime.Now.Date;

        // Tinh tuoi hien tai
        int tuoi = homNay.Year - ngaySinh.Year;
        if (homNay.Month < ngaySinh.Month || (homNay.Month == ngaySinh.Month && homNay.Day < ngaySinh.Day))
        {
            tuoi--;
        }

        // Tong so ngay da song
        TimeSpan soNgayDaSong = homNay - ngaySinh;

        // Tim sinh nhat tiep theo
        DateTime sinhNhatNamNay = new DateTime(homNay.Year, ngaySinh.Month, ngaySinh.Day);
        DateTime sinhNhatTiepTheo;

        if (sinhNhatNamNay >= homNay)
        {
            sinhNhatTiepTheo = sinhNhatNamNay;
        }
        else
        {
            sinhNhatTiepTheo = new DateTime(homNay.Year + 1, ngaySinh.Month, ngaySinh.Day);
        }

        TimeSpan soNgayConLai = sinhNhatTiepTheo - homNay;

        Console.WriteLine();
        Console.WriteLine("Tuoi hien tai: " + tuoi + " tuoi");
        Console.WriteLine("Ban da song tong cong: " + (int)soNgayDaSong.TotalDays + " ngay");
        Console.WriteLine("Sinh nhat tiep theo con: " + (int)soNgayConLai.TotalDays + " ngay nua");
    }
    static void Excercise8()
    {
        Console.Write("C# (4 TC): ");
        double diemCSharp = Convert.ToDouble(Console.ReadLine());
        int tinChiCSharp = 4;

        Console.Write("Toan (3 TC): ");
        double diemToan = Convert.ToDouble(Console.ReadLine());
        int tinChiToan = 3;

        Console.Write("Tieng Anh (2 TC): ");
        double diemTiengAnh = Convert.ToDouble(Console.ReadLine());
        int tinChiTiengAnh = 2;

        int tongTinChi = tinChiCSharp + tinChiToan + tinChiTiengAnh;

        double diemTB = (diemCSharp * tinChiCSharp + diemToan * tinChiToan + diemTiengAnh * tinChiTiengAnh) / tongTinChi;

        char diemChu;
        double gpa;
        string xepLoai;

        if (diemTB >= 8.5)
        {
            diemChu = 'A';
            gpa = 4.0;
            xepLoai = "Xuat sac / Gioi";
        }
        else if (diemTB >= 7.0)
        {
            diemChu = 'B';
            gpa = 3.0;
            xepLoai = "Kha";
        }
        else if (diemTB >= 5.5)
        {
            diemChu = 'C';
            gpa = 2.0;
            xepLoai = "Trung binh";
        }
        else if (diemTB >= 4.0)
        {
            diemChu = 'D';
            gpa = 1.0;
            xepLoai = "Yeu";
        }
        else
        {
            diemChu = 'F';
            gpa = 0.0;
            xepLoai = "Kem (Truot)";
        }

        Console.WriteLine();
        Console.WriteLine("Diem TB Thang 10: " + diemTB.ToString("F2"));
        Console.WriteLine("Diem Chu Quy Doi: " + diemChu);
        Console.WriteLine("Diem GPA Thang 4: " + gpa.ToString("F1"));
        Console.WriteLine("Xep Loai Hoc Luc: " + xepLoai);
    }
}*/