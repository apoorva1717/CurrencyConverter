using System;

namespace CurrencyConverter2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            userInput.AcceptInput();

            string[] inputArray = userInput.FormatInput();

            ValidateUserInput validateUserInput = new ValidateUserInput();
            
            try
            {
                double exchangeAmount = validateUserInput.ValidateInput(inputArray);

                CurrencyExchange currencyExchange = new CurrencyExchange();

                double result = currencyExchange.CurrencyConverter(inputArray[1].ToUpper(), inputArray[2].ToUpper(), exchangeAmount);
                Console.WriteLine(result);
    
            }
            catch (UnknownCurrencyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
