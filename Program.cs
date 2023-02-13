using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFromFile
{
    internal class Program
    {

        static string contents;
        static void Main(string[] args)
        {
            Console.WriteLine("Reading & Writing Files:");

            if (System.IO.File.Exists("files/myfile.txt") == false)
            {
                System.IO.File.Create("files/myfile.txt").Close();
                Console.WriteLine("No file exists, please enter a line to save:");
                contents = Console.ReadLine();
                System.IO.File.WriteAllText("files/myfile.txt", contents);
            }
            
            else
            {
                contents = System.IO.File.ReadAllText("files/myfile.txt");
                Console.WriteLine("File exists, contents:");
                Console.WriteLine(contents);
            }
            
            Console.WriteLine("Update the file contents?");
            ConsoleKeyInfo choice = Console.ReadKey(true);
            
            if (choice.Key == ConsoleKey.Y)
            {
                Console.WriteLine("Please enter a line to save:");
                contents = Console.ReadLine();
                System.IO.File.WriteAllText("files/myfile.txt", contents);
            }
            
            Console.WriteLine("Thank you!");
            Console.ReadKey(true);
        }
    }
}
