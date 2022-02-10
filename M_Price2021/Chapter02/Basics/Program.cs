// See https://aka.ms/new-console-template for more information
//#error version
using System; // точка с запятой указывает на конец оператора
using System.Linq;
using System.Reflection;
 

namespace Basics

{ // открывающая фигурная скобка указывает на начало блока

  class Program

  {

    static void Main(string[] args)

    {
      //объявление некоторых неиспользуемых переменных с помощью типов в дополнительных сборках
      System.Data.DataSet ds;
      System.Net.Http.HttpClient client;

      char letter='A';//присвоение литеральных символов
      char digit='1';
      char symbol='$';
      
      char userChoise = GetKeystroke();// присвоение из функции

      string firstName = "Bob"; //присвоение литеральных строк
      string lastName = "Smith";
      string phoneNumber = "(215)555-4256";

      // присваивание строки, возвращаемой функцией

      string address = GetAddressFromDatabase(id: 563);
      string fullNameWithTabSeparator = "Bob\tSmith";
      string filePath = "C:\televisions\sony\bravia.txt";
      string filePath = @"C:\televisions\sony\bravia.txt";


      //присвоение строки, возвращаемой функцией
      string address = GetAddressFromDatabase(id: 563);

      //Перебор сборок, на которые ссылается приложение
      foreach (var r in Assembly.GetEntryAssembly() .GetReferencedAssemblies())
      {
        //загрузка сборки для чтения данных
        var a = Assembly.Load(new AssemblyName(r.FullName));
        //объявление переменной для подсчета методов
        int methodCount = 0;
        //перебор всех типов в сборке
        foreach (var t in a.DefinedTypes)
        {
          //добавление количества методов
          methodCount += t.GetMethods().Count();
        }
        //вывод количества типов и их методов
        Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0: a.DefinedTypes.Count(), arg1: methodCount, arg2: r.Name);

      }
      //выводит возврат коретки
      Console.WriteLine();
      //выводит приветствие и возврат каретки
      Console.WriteLine("Привет, Володя");
      //выводит отформатированное число и дату и возврат каретки

      Console.WriteLine("Temperature on {0:D} is {1}°C.", DateTime.Today, -23.4);
      //присвоение переменной heightInMetres значения, равного, 1,88
      double heightInMetres = 1.88;
      Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");
      

    }

  }

} // закрывающая фигурная скобка указывает на конец блока