using System;
namespace Uppgift3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en addition, subtraktion, multiplikation eller division med två tal:");
            string calc = Console.ReadLine();

            string sign = calc.Contains("+") ? "+" : (calc.Contains("-") ? "-" : (calc.Contains("*") ? "*" : "/")); //Vilket räknesätt?

            int signIndex = calc.IndexOf(sign); //Index för sign
            double number1 = double.Parse(calc[..signIndex]);  //Tal 1
            double number2 = double.Parse(calc[(signIndex + 1)..]);  //Tal 2

            if (sign == "+") //Plus
            {
                Console.WriteLine($"{calc} = {number1 + number2}");
            }
            else if (sign  == "-") //Minus
            {
                Console.WriteLine($"{calc} = {number1 - number2}");
            }
            else if (sign == "*") //Gånger
            {
                Console.WriteLine($"{calc} = {number1 * number2}");
            }
            else //Delat med
            {
                Console.WriteLine($"{calc} = {number1 / number2}");
            }
        }
    }
}