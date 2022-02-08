using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(directory);
            string path = directory + "Config.txt";
            string pathip = directory + "AllIP.txt";
            string pathacl = directory + "AllAcM.txt";
            //int count = System.IO.File.ReadAllLines(path).Length;
            //Console.WriteLine(count);
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line = "";
                string preline = line;
                bool Comptext;
                bool Comptext2;
                while ((line = await sr.ReadLineAsync()) != null)
                {

                    string ip = "ip access-list extended ";
                    string math = "match ip address ";
                    Comptext = line.Contains(ip);
                    Comptext2 = line.Contains(math);

                    if (Comptext == true)
                    {
                        //Console.WriteLine(line);
                        try
                        {
                            string writePath1 = directory + "AllIP.txt";
                            using (StreamWriter sw = new StreamWriter(writePath1, true, System.Text.Encoding.Default))
                            {
                                await sw.WriteLineAsync(line);
                            }
                            //Console.WriteLine("Запись выполнена");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }
                    if (Comptext2 == true)
                    {
                        //Console.WriteLine(preline);
                        try
                        {
                            string writePath2 = directory + "AllAcM.txt";
                            using (StreamWriter sw = new StreamWriter(writePath2, true, System.Text.Encoding.Default))
                            {
                                await sw.WriteLineAsync(preline);
                                await sw.WriteLineAsync(line);
                            }
                            //Console.WriteLine("Запись выполнена");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    preline = line;
                }
            }
            using (StreamReader sr = new StreamReader(pathip, System.Text.Encoding.Default))
            {
                string line = "";
                //string preline = "";
                bool Comptext;
                bool Compfile1;
                while ((line = await sr.ReadLineAsync()) != null)
                {

                    string ip = "ip access-list extended ";
                    string acl = "";
                    string acl1 = "";
                    Comptext = line.Contains(ip);
                    int L = line.Length;
                    int L1 = ip.Length;
                    for (int i = L1; i < L; i++)
                    {
                        char s = line[i];
                        acl = acl + s;
                    }
                    //Console.WriteLine(acl);
                    acl1 = acl;
                    acl = "";
                    //Console.WriteLine(acl1);
                    string str = File.ReadAllText(directory + "AllAcM.txt");
                    Compfile1 = str.Contains(acl1);
                    //Console.WriteLine(str);
                    //Console.WriteLine(Compfile1);
                    if (Compfile1 == false)
                    {
                        try
                        {
                            string writePath3 = directory + "DelNotUse.txt";
                            using (StreamWriter sw = new StreamWriter(writePath3, true, System.Text.Encoding.Default))
                            {
                                await sw.WriteAsync("no ");
                                await sw.WriteLineAsync(line);
                            }
                            //Console.WriteLine("Запись выполнена");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                }
            }
            using (StreamReader sr = new StreamReader(pathacl, System.Text.Encoding.Default))
            {
                string line = "";
                string preline = "";
                bool Comptext;
                bool Compfile1;
                while ((line = await sr.ReadLineAsync()) != null)
                {

                    string mat = "match ip address ";
                    string acl = "";
                    string acl1 = "";
                    Comptext = line.Contains(mat);
                    int L = line.Length;
                    int L1 = mat.Length;
                    for (int i = L1; i < L; i++)
                    {
                        char s = line[i];
                        acl = acl + s;
                    }
                    //Console.WriteLine(acl);

                    acl1 = acl;
                    acl = "";

                    string str = File.ReadAllText(directory + "AllIP.txt");
                    Compfile1 = str.Contains(acl1);

                    //Console.WriteLine(Compfile1);
                    if (Compfile1 == false && Comptext == true)
                    {
                        try
                        {
                            string writePath3 = directory + "DelNotUse.txt";
                            using (StreamWriter sw = new StreamWriter(writePath3, true, System.Text.Encoding.Default))
                            {

                                await sw.WriteAsync("no ");
                                await sw.WriteLineAsync(preline);

                            }
                            //Console.WriteLine("Запись выполнена");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    preline = line;
                }
                
            }

        }
    }
}