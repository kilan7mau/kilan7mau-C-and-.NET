// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1= new MyClass();
            Console.WriteLine($"HelloWord!{c1.ReturnMessage()}");
        }
    }
}

