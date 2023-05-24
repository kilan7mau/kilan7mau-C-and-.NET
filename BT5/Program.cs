// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Ex5-nhập vào ngày tháng năm sinh -> in ra số ngày cần để tới sinh nhật tiếp theo
using System;
namespace Ex5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap ngay thang nam sinh: ");
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime birthday = new DateTime(year, month, day);
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            int daysUntilBirthday = (nextBirthday - today).Days;
            Console.WriteLine("So ngay can de toi sinh nhat tiep theo la: " + daysUntilBirthday);
            
        }
    }
}