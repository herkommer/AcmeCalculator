using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCalculator
{
    public class Calculate : ICalculator
    {
        public decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public decimal Subtract(decimal number1, decimal number2)
        {
            return number1 - number2;
        }
    }
}
