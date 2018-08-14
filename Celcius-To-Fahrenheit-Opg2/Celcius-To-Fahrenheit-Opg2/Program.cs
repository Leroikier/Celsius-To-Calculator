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
            Console.WriteLine("Indtast Fahrenheit");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celcius * 9 / 5) + 32;
            double kelvin = celcius + 273.15;
            double reaumur = celcius * 0.8;

            Console.WriteLine("Celcius til Fahrenheit = {0}",fahrenheit);
            Console.WriteLine("Celcius til Kelvin = {0}",kelvin);
             Console.WriteLine("Celcius til Réaumur = {0}",reaumur);


            Console.ReadKey();
        }
    }
}
