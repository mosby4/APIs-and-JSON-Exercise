using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {RonVSKanyeAPI.kanyeQuote()}");
                Console.WriteLine();
                Console.WriteLine($"Ron:{RonVSKanyeAPI.ronQuote()}");
            }

        }
    }
}
