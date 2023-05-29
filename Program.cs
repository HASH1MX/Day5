using System;
using System.IO;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           //string folderPath = "D:\\Coding\\KB\\Cheat Sheet";
           
           //string folderPath = Console.ReadLine();
            string folderPath = args[0];

             DirectoryInfo dir = new DirectoryInfo(folderPath);

             FileInfo[] files = dir.GetFiles("*.*");

             foreach(FileInfo f in files )
               {

                 Console.WriteLine(f);
                
                }

            //Console.WriteLine(dir);
            //Console.WriteLine(folderPath); 

        }
    }
}