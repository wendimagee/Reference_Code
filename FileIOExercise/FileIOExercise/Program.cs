using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\wendi\source\repos\FileIOExercise\FileIOExercise\bin\Debug\Countries.txt";

            Console.WriteLine(filePath);
            //We to need save, the way you do that is via a streamWriter 
            StreamReader reader;
            StreamWriter writer;
            try
            {
                //we try and open the file along the file path 
                //The reader or writer will throw a file not found exception 
                reader = new StreamReader(filePath);
                string fileOutput = reader.ReadToEnd();
                List<string> existingCountries = fileOutput.Split(',').ToList();

                Console.WriteLine("Existing Countries in the file: ");
                PrintCountryList(existingCountries);

                Console.WriteLine("Please input a country name");
                string inputCountry = Console.ReadLine();
                Console.WriteLine("Adding new country...");
                Console.WriteLine();

                if (!fileOutput.Contains(inputCountry))
                {
                    fileOutput += $", {inputCountry}";
                    Console.WriteLine("New Country added!");
                    Console.WriteLine(fileOutput);
                }
                else
                {
                    Console.WriteLine("That country already exists, the file has not been changed");
                    Console.WriteLine(fileOutput);
                }

                //countries = fileOutput.Split(',').ToList();
                reader.Close();

                writer = new StreamWriter(filePath);
                writer.Write(fileOutput);

                writer.Close();
                //PrintCountryList(countries);
            }
            //With File IO you almost always want to put a try catch around it 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            //Where have we seen read and write before?


        }

        public static void PrintCountryList(List<string> countries)
        {
            foreach (string country in countries)
            {
                Console.WriteLine(country.Trim());
            }
        }
    }
}
