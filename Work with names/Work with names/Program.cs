using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Work_with_names
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Обрабатываю данные");
                string path = "names.txt";

                using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
                {
                    List<string> names = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        string name = reader.ReadLine();
                        names.Add(name);
                    }

                    List<string> uniqueNames = new List<string>();

                    foreach (string name in names)
                    {
                        string capitalizedName = char.ToUpper(name[0]) + name.Substring(1); 
                        if (!uniqueNames.Contains(capitalizedName))
                        {
                            uniqueNames.Add(capitalizedName);
                            Console.Write("."); 
                        }
                    }

                    uniqueNames.Sort();

                    string resultPath = "result.txt";

                    using (StreamWriter writer = new StreamWriter(new FileStream(resultPath, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (string name in uniqueNames)
                        {
                            writer.WriteLine(name);
                        }
                    }

                    Console.WriteLine("\nОбработка данных завершена");
                    Console.WriteLine($"Имен в списке: {uniqueNames.Count}");
                    
                }
            }

            Console.ReadKey();
        }
    }
}

