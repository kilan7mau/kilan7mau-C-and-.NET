// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Ex3-Hiển thị lời chào
using System;
namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello: " + yourName);
            Console.WriteLine($"Hello: {yourName}");
        }
    }   
}