using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter2.Interfaces
{
     public interface ICurrencyExchange
     {
        public double CurrencyConverter(string mainCurrency, string moneyCurrency, double exchangeAmount);
   
     }
}
