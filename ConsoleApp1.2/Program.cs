using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            var names = new List<string> { "ioana", "Ana", "Fiona" };
            foreach (var name in names)
            {
                Console.WriteLine($"hello {name.ToUpper()}!");
            }

            //2
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Ion");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($" I've added {names[2]} and {names[3]} to the list.");
            //3
            Console.WriteLine($"The list has {names.Count} people in it");
            //4
            var index = names.IndexOf("Ioana");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notfound = names.IndexOf("Not Found");
            Console.WriteLine($"Then an item is not found, IndexOf returns {notfound}");
            //5
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"hello {name.ToUpper()}!");
            }
        }
    }
}


