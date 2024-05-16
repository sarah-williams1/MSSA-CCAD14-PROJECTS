// Write a console app that creates a text file and saves your name, age, and address. Then read the file and print on console.
using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Assignment_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile();
            ReadFile();

            static void WriteFile()
            {
                Console.WriteLine("What is your name?");
                string myName = Console.ReadLine();
                Console.WriteLine("What is your age?");
                string myAge = Console.ReadLine();
                Console.WriteLine("What is your address?");
                string myAddress = Console.ReadLine();

                try
                {
                    StreamWriter sw = new StreamWriter("C:\\Users\\swill\\Desktop\\Information.txt");

                    sw.WriteLine("What is your name?\n\tMy name is " + myName);

                    sw.WriteLine("What is your age?\n\tI am " + myAge + " years old");

                    sw.WriteLine("What is your address?\n\tMy address is " + myAddress);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("This is the end.");
                }
            }

            static void ReadFile()
            {
                String line;
                try
                {

                    StreamReader sr = new StreamReader("C:\\Users\\swill\\Desktop\\Information.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception: " + exception);
                }
                finally
                {
                    Console.WriteLine("Executing nothing.");
                }

            }
        }
    }
}
