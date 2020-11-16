using System;
using System.IO;

namespace ReadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string path = "in.txt";
            //string path = "pf2.txt";
            //using (StreamReader reader = new StreamReader("C:\\Users\\Israe\\Documents\\ForICE.txt"))
            //Or
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while ((str = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }
                }
                Console.WriteLine(File.GetCreationTime(path));
                Console.WriteLine(File.GetLastWriteTime(path));
                Console.WriteLine($"\n{File.ReadAllText(path)}\n");
                string[] readText = File.ReadAllLines(path);
                foreach (string s in readText)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("File is not found");
            }

        }
    }
}
