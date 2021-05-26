using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter2.Interfaces
{
     public interface IUser
     {
        public string[] AcceptInput();

        public double ValidateInput();
     }
}
