using System;
using System.Collections.Generic;

namespace CurrencyConverter2
{
    class CurrencyExchange
    {
        private Dictionary<string, float> _exchangeRates;
        public const double UnknownCurrency = -1;

        public CurrencyExchange()
        {
            ExchangeRatesData data = new ExchangeRatesData();
            _exchangeRates = data.GetExchangeRates();
        }
        
        
        public double CurrencyConverter(string mainCurrency, string moneyCurrency, double exchangeAmount)
        {

            if (_exchangeRates.ContainsKey(mainCurrency) && _exchangeRates.ContainsKey(moneyCurrency))
            {
                double outputAmount;
                outputAmount = _exchangeRates[mainCurrency] / _exchangeRates[moneyCurrency] * exchangeAmount;
                return Math.Round(outputAmount, 4);
            }

            else
            {
                throw new UnknownCurrencyException("Unknown Currency!");
            }

        }
    }
}
