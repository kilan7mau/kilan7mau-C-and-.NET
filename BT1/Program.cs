// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// BT1_Hiển thị thời gian hệ thống
using System;
namespace Ex1
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            System.Console.WriteLine("Datetime Now is :" + localDate);
            Console.WriteLine($"Datetime Now is : {localDate}");
        }
    }
}