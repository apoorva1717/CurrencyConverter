using System;

namespace CurrencyConverter2
{
    class ValidateUserInput
    {
        public double ValidateInput(string[] inputArray)
        {
            double exchangeAmount;
            bool isParsable = Double.TryParse(inputArray[3], out exchangeAmount);

            if (!isParsable)
            {
                throw new InvalidAmountException("Enter a Valid Numerical Amount to Exchange!");
            }

            if (exchangeAmount < 0)
            {
                throw new InvalidAmountException("Enter an amount greater than 0!");
            }

            return exchangeAmount;

        }
    }
}
