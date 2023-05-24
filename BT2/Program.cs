// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//BT2-Sử dụng toán tử
using System;
namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float width, height;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);
            
            
        }
    }
}