using System;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] names = new string[4];
        // хранение элементов с индексами позиций
        names[0] = "Kate";
        names[1] = "Jack";
        names[2] = "Rebecca";
        names[3] = "Tom";
        //перебираем имена
        for (int i = 0; i < names.Length; i++)
            {
                //прочитать элемент с данным индексом позиции
                Console.WriteLine(names[i]);
            }
        }
    }
}
