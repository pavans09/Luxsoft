using System;
using System.IO;

namespace Luxsoft
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please input file path:");
            string filepath = Console.ReadLine();
            Console.WriteLine("Please input file data type:");
            string dataType = Console.ReadLine();
            string inputData = File.ReadAllText(filepath);
            FileDataSource fd = new FileDataSource();
            Console.WriteLine(fd.GetData(inputData, dataType));
            Console.ReadKey();
        }
    }
}
