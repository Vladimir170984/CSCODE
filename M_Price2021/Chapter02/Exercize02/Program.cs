// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace Exersize02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("--------------------------------------------------------------------------");
            WriteLine("Type    Byte(s) of memory               Min                            Max");
            WriteLine("--------------------------------------------------------------------------");
            WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
            WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
            WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
            WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
            WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
            WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
            WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
            WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
            WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
            WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
            WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
            WriteLine("--------------------------------------------------------------------------");

            int MyInt = 100;
            WriteLine("{0:C}", MyInt);

            string s1 = "Hello ";
            string s2 = s1;
            s1 += "World";

            Console.WriteLine(s1);

            

            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
            Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");


            var pw = (firstName: "Phillis", lastName: "Wheatley", born: 1753, published: 1773);
            Console.WriteLine("{0} {1} was an African American poet born in {2}.", pw.firstName, pw.lastName, pw.born);
            Console.WriteLine("She was first published in {0} at the age of {1}.", pw.published, pw.published - pw.born);
            Console.WriteLine("She'd be over {0} years old today.", Math.Round((2018d - pw.born) / 100d) * 100d);

            string s3 = "Visual C# Express";
            System.Console.WriteLine(s3.Substring(7, 2));
            // Output: "C#"

            System.Console.WriteLine(s3.Replace("C#", "Basic"));
            // Output: "Visual Basic Express"

            // Index values are zero-based
            int index = s3.IndexOf("C");
            // index = 7
           
           string s5 = "Printing backwards";

            for (int i = 0; i < s5.Length; i++)
                {
                   Console.Write(s5[s5.Length - i - 1]);
                }

            



        }
    }
}


