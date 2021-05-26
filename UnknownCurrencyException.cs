using System;

namespace CurrencyConverter2
{
    class UnknownCurrencyException : Exception
    {
        public UnknownCurrencyException(string message) : base(message) { }
           
    }
}
