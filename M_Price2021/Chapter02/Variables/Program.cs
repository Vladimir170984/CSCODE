﻿// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Xml;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
           
           
            Console.WriteLine("Hello, C#!");
            object height = 1.81; // запись double в object
            object name = "Vova"; // запись string в object
            Console.WriteLine($"{name} is {height} metres tall.");
            //int length1 = name.Length; //выдает ошибку компиляции
            int length2 = ((string)name).Length; //сообщение компилятору, что это строка

            Console.WriteLine($"{name} has {length2} characters.");

            //хранение строки как dynamic
            dynamic anotherName = "Michail";
            
            // компилируется, но может вызвать исключение во время
            // выполнения, если вы позже сохраните тип данных,
            // у которого нет свойства Length
            int length = anotherName.Length;
           
            Console.WriteLine($"{anotherName} has {length} characters.");
            var population = 66_000_000; // 66 миллионов человек в Великобритании
            var weight = 1.88; // в килограммах
            var price = 4.99M;  // в фунтах стерлингов
            var fruit = "Apples";     // строки в двойных кавычках
            var letter = 'Z';          // символы в одиночных кавычках
            var happy = true;           // логическое значение — true или false


            // удачное применение var, поскольку он избегает повторного типа
            var xml1 = new XmlDocument();
            XmlDocument xml2 = new XmlDocument();

            // неудачное применение var,
            // поскольку мы не можем определить тип, поэтому должны использовать
            // конкретное объявление типа, как показано во втором выражении
            var file1 = File.CreateText(@"C:\something.txt");
            StreamWriter file2 = File.CreateText(@"C:\something.txt");

            XmlDocument xml3 = new(); // целевой тип выражения new (версия C# 9)

           

        }
    }
}
