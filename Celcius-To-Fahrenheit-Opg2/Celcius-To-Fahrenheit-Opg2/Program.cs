using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celcius_To_Fahrenheit_Opg2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.WriteLine("");
            Console.Write("  Indtast Celcius ");
            double celcius = double.Parse(Console.ReadLine());

            //Udregninger
            double fahrenheit = (celcius * 9 / 5) + 32;
            double kelvin = celcius + 273.15;
            double reaumur = celcius * 0.8;

            //Output
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("  {0} Celcius til Fahrenheit er = {1} ",celcius ,fahrenheit);
            Console.WriteLine("  {0} Celcius til Kelvin = {1} ",celcius ,kelvin);
            Console.WriteLine("  {0} Celcius til Réaumur = {1} ",celcius ,reaumur);

            //Slut
            Console.ReadKey();
        }
    }
}