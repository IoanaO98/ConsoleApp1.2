﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exercitii
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            //1
            string characterName = "Ana";
            int characterAge;
            characterAge = 20;
            Console.WriteLine("There once was a girl named " + characterName);
            Console.WriteLine("She was " + characterAge + "years old");
            Console.WriteLine("She really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            //2

            var names = new List<string> { "ioana", "Ana", "Fiona" };
            foreach (var name in names)
            {
                Console.WriteLine($"hello {name.ToUpper()}!");
            }
            names.Add("Maria");
            names.Add("Ion");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($" I've added {names[2]} and {names[3]} to the list.");

            //4
            Console.WriteLine($"The list has {names.Count} people in it");

            //5
            var index = names.IndexOf("Ioana");

            //3
            Console.WriteLine();
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notfound = names.IndexOf("Not Found");
            Console.WriteLine($"Then an item is not found, IndexOf returns {notfound}");

            //6
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"hello {name.ToUpper()}!");
            }

            //7
            var fibonacciNumbers = new List<int> { 1, 1 };
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            fibonacciNumbers.Add(previous + previous2);
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
            //8

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            fibonaciiNumbers(cars);


            string[] ceva = { "1", "2", "3" };
            sentencelength(ceva);

            string[] nume = { "Ioana", "Paula", "Bunica" };
            enterName(nume);

            string[] numere = { "1", "2", "3" };
            ConversNumber(numere);

            string[] story = { "color", "pluralNoun", "celebrity" };
            MadLid(story);

            string[] array = { "luckyNumbers", "friends" };
            arraySI(array);

            string[] Guru = { "file", "exist" };
            FileExist(Guru);
            Console.ReadLine();
        }

        static void fibonaciiNumbers(string[] args)
        {
            List<int> fibonaciiNumbers = new List<int> { 1, 1 };
            while (fibonaciiNumbers.Count < 20)
            {
                int previous = fibonaciiNumbers[fibonaciiNumbers.Count - 1];
                int previous2 = fibonaciiNumbers[fibonaciiNumbers.Count - 2];
                fibonaciiNumbers.Add(item: previous + previous2);
            }
            foreach (int item in fibonaciiNumbers)
                Console.WriteLine(item);
        }

        static void sentencelength(string[] args)

        {
            //2. Write a program in C# Sharp to find the length of a string without using library function

            string sentence = "Maria are mere";

            Console.WriteLine($"The sentence {sentence} has the {sentence.Length} letters ");
            Console.ReadLine();
        }
        static void enterName(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);

        }
        static void ConversNumber(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            //decimal
            Console.Write("Enter a decimal number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another decimal number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num3 + num4);
            Console.ReadLine();
        }
        static void MadLid(string[] args)
        {
            string color, pluralNoun, celebrity;

                Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();
            Console.WriteLine("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();
        }
        static void arraySI(string[] args)
        {
            int[] luckyNumbers = { 4, 5, 7, 23, 34, 45};
            string[] friends = new string[5];
            friends[0] = "Jim";
            Console.WriteLine(luckyNumbers[0]);
        }
        static void FileExist(string[] args)
        {
            string path = @"D:\Example.txt";
            if (File.Exists(path));
            Console.WriteLine("File Exists");

            Console.ReadKey();

        }



    }

}
