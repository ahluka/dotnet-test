using System;
using System.Collections.Generic;

namespace dotnet_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {"Lee", "Sab", "Bing Bing"};

            foreach (var name in names) {
                Console.WriteLine($"Hello {name}!");
                Console.WriteLine("TIMMY!");
            }
        }
    }
}
