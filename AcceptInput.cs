using System;

namespace CurrencyConverter2
{
    class UserInput
    {
        private string _userInput;
        private string[] _inputArray;

        public void AcceptInput()
        {
         _userInput = Console.ReadLine();
        }

        public string[] FormatInput()
        {
            _inputArray = _userInput.Split(new Char[] { ' ', '/' });
            return _inputArray;
        }

    }
}
