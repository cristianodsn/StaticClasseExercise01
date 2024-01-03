using System;
using System.Globalization;

namespace Rascunho
{
    class CurrencyConverter
    {
        static private double IOF = 6.00;

        static public double ConverterReaisToDollar(double DollarExchangeRate, double quantity)
        {
            double total = DollarExchangeRate * quantity;
            return +total + total / 100 * IOF;
        }
    }
}
