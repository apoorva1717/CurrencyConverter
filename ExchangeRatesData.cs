using System.Collections.Generic;

namespace CurrencyConverter2
{
    class ExchangeRatesData
    {
        private Dictionary<string, float> _exchangeRates = new Dictionary<string, float>();

        public ExchangeRatesData()
        {
            _exchangeRates.Add("EUR", 743.94f / 100);
            _exchangeRates.Add("USD", 663.11f / 100);
            _exchangeRates.Add("GBP", 852.85f / 100);
            _exchangeRates.Add("SEK", 76.10f / 100);
            _exchangeRates.Add("NOK", 78.40f / 100);
            _exchangeRates.Add("CHF", 683.58f / 100);
            _exchangeRates.Add("JPY", 5.9740f / 100);
            _exchangeRates.Add("DKK", 100 / 100);
        }

        public Dictionary<string, float> GetExchangeRates()
        {
            return _exchangeRates;
        }
    }
}
