using System;

namespace bool2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool result =a%2!=0 && b%2!=0;
            Console.WriteLine(result);
        }
    }
}