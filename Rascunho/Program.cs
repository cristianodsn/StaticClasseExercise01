using System;
using System.Globalization;

namespace Rascunho
{
    class Program
    {      
        static void Main(string[] args)
        {

            Console.Write("What is the dollar exchange rate:");
            double exchangeRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many dollars will you buy:");
            double dollarBuy = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            double totalQuantityReais = CurrencyConverter.ConverterReaisToDollar(exchangeRate, dollarBuy);
            Console.WriteLine("Amount to be paid in reais: " + totalQuantityReais.ToString("F2", CultureInfo.InvariantCulture) );
            Console.ReadKey();
        }      

    }
}
