﻿#nullable enable
using System;

namespace HelloCS
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int thisCannotBeNull = 4;

            //thisCannotBeNull = null; // ошибка компиляции!    
            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
            

            int? thisCouldBeNull = null;

            Console.WriteLine(thisCouldBeNull);

            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());            

            thisCouldBeNull = 7;

            Console.WriteLine(thisCouldBeNull);

            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());


            // проверить thisCouldBeNull на значение null перед использованием
            //if(thisCouldBeNull != null)
            //{
            //    //получить доступ к thisCouldBeNull
            //    int length = thisCouldBeNull.Length;//может возникнуть исключение                
            //}
            string authorName = null;
            //выдаст исключение NullReferenceException
            //int x = authorName.Length;
            // вместо вызова исключения, y получит значение null
            int? y = authorName?.Length;

            // результат равен 3, если authorName?.Length равен нулю, с помощью оператора объединения с null (??)

            var result = authorName?.Length ?? 3;

            Console.WriteLine(result);
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            Console.WriteLine(format: "{0} apples costs {1:C}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);
            string formatted = string.Format(format: "{0} apples costs {1:C}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);
<<<<<<< HEAD
            //WriteToFile(formatted); // записывает строку в файл
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");
=======
            //WriteToFile(formatted); //записывает строку в файл
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");


>>>>>>> a4f0a39ab1a777ebd21074baff2e29dafbf06405


        }
    }
}