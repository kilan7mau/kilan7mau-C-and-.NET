// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Ex4-Ứng dụng chuyển đổi tiền tệ
using System;
namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double rate = 23000;
            Console.WriteLine("Nhap so tien USD: ");
            double usd = double.Parse(Console.ReadLine());
            double vnd = usd * rate;
            Console.WriteLine("So tien VND: " + vnd);
        }
    }
}
