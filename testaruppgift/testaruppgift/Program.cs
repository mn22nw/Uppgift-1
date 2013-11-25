using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testaruppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            do
                {try
            {
                         double value5 = Math.Pow(2, 3);
                    Console.Write("Ange triangelns mått för varje sida, separerat med mellanslag: ");
                    string input = Console.ReadLine();
                    string[] inputs = input.Split(' ');
                    try
                    {
                        Triangle t = new Triangle(double.Parse(inputs[0]), double.Parse(inputs[1]), double.Parse(inputs[2]));
                        Console.WriteLine("\nRESULTAT\n___________________\n");
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        if (t.isScalene()) Console.WriteLine("Triangeln har inga lika sidor");
                        if (t.isEquilateral()) Console.WriteLine("Triangeln är liksidig");
                        if (t.isIsosceles()) Console.WriteLine("Triangeln är likbent");
                        Console.ResetColor();
                    }
                    catch (ArgumentException e)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(e.Message);
                        Console.ResetColor();
                    }
                   
            }
                catch 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Det har blivit något fel, Försök igen!");
                    Console.ResetColor();
                }
                }
                while (true);
        }
           
        }
    }

