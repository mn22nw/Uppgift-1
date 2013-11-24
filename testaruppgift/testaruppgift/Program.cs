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
             //Exempel på användning: 
         
          /*   double[] input = new double[3];
            for(int i=0;i<2;i++)
            input[i]=double.Parse(args[i]);*/
            do
                {try
            {
                    Console.Write("\nAnge första sidan av triangeln: ");
                    double input1 = double.Parse(Console.ReadLine());
                    Console.Write("Ange andra sidan av triangeln:  ");
                    double input2 = double.Parse(Console.ReadLine());
                    Console.Write("Ange tredje sidan av triangeln: ");
                    double input3 = double.Parse(Console.ReadLine());

                    Triangle t = new Triangle(input1, input2, input3);
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
                while (true);
        }
           
        }
    }

