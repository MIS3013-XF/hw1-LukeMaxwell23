// HW1a Sales Total

// Your Name: Luke Maxwell
// Did you seek help ? If yes, specify the helper or web link here: I used the code that I wrote in class as a guide to help

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleTotal

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double num1;
            double num2;

            double sum1;
            double sum2;
            double sum3;

            const double multiplier = 0.085;

            string Num1AsString;
            string Num2AsString;
            string Num3AsString;

            Console.WriteLine("What is the item you are purchasing?");
            Num1AsString = Console.ReadLine();
            Console.WriteLine("How many " + Num1AsString +"'s are you purchasing?");
            Num2AsString = Console.ReadLine();
            Console.WriteLine("What is the price for each " + Num1AsString);
            Num3AsString = Console.ReadLine();

            num1 = Convert.ToDouble(Num2AsString);
            num2 = Convert.ToDouble(Num3AsString);

            sum1 = num1 * num2;
            Console.WriteLine("The subtotal of your bill is $" + sum1.ToString("N2"));

            sum2 = sum1 * multiplier;
            Console.WriteLine($"The sales tax for your bill is ${sum2}");

            sum3 = sum1 + sum2;
            Console.WriteLine("The total of your bill is $" + sum3.ToString("N2"));
            Console.ReadKey();


        }
    }
}