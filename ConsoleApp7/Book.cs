using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    internal class Book:Product
    {
        public string Genre { get; set; }
        public Book(string name, double price, int count, string genre) : base(name, price, count)
        {
            Genre = genre;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Count: {Count}");
        }
    }
}
