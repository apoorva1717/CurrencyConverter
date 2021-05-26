using System;

namespace CurrencyConverter2
{
    class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message) { }

    }
}
