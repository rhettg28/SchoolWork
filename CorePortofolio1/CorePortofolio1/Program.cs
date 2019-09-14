/* 
Purpose:    To create a program that compounds the interest of a bank account
 
Input:      P = principal amount, r = annual interest, n = times per year interest is compounded, t = number of years
 
Output:     F = will be the compounded intereset of the bank account
             
Author:           Rene Guillena
Last modified:    2019.09.14
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePortofolio1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Add original amount of money in account here as a double: ");
            double pAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Add annual interest rate here as a double: ");
            double rInterest = double.Parse(Console.ReadLine())/100;

            Console.WriteLine("Compound periods can be 1 for yearly, 2 for semi-annually, 4 for quarterly, 12 for monthly");
            Console.WriteLine("Add compound period here (1, 2, 4, 12): ");
            int nTimes = int.Parse(Console.ReadLine());

            Console.WriteLine("Add number of years here: ");
            int tTimes = int.Parse(Console.ReadLine());

            double fTotal = pAmount * Math.Pow(1 + (rInterest / nTimes), (nTimes * tTimes));

            Console.WriteLine($"Future value of your money is: ${fTotal:n}");
            Console.WriteLine($"Principal Investment Amount: ${pAmount:n}");
            Console.WriteLine($"Annual Interest Rate: {(rInterest * 100):n1}%");
            Console.WriteLine($"Compounds per year: {nTimes}");
                



        }
    }
}
