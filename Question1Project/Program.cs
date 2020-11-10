using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Question1and3Project
{
    public class Program
    {

        public void doesFileExist(string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    Console.WriteLine("File is available");
                    List<string> lines = File.ReadAllLines(filepath).ToList();
                    int linecounter = 1;
                    foreach (string line in lines)
                    {
                        int counter = 1;
                        Console.WriteLine("\n\n");
                        string[] words = line.Trim().Split('–');
                        Console.WriteLine("Word" + linecounter + "\n\n" + words[0]);
                        Console.WriteLine("Meaning " + counter + "\n" + words[1].Split(',')[0]);
                        counter++;
                        Console.WriteLine("Meaning " + counter + "\n" + words[1].Split(',')[1]);
                        linecounter++;
                    }
                }
                else
                {
                    Console.WriteLine("File  path is not valid!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            try
            {                
                string filepath = @"../../../SampleFile.txt";
                Program obj = new Program();
                obj.doesFileExist(filepath);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
