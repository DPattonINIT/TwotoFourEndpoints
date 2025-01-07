using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwotoFourEndpoints.Services
{
    public class ComparisonService
    {
        public string CompareNumbers(int num1, int num2)
        {
            string statement1 = Compare(num1, num2);
            string statement2 = Compare(num2, num1);
            return $"{statement1} {statement2}";
        }

        private string Compare(int num1, int num2)
        {
            if (num1 > num2)
                return $"{num1} is greater than {num2}.";
            else if (num1 < num2)
                return $"{num1} is less than {num2}.";
            else
                return $"{num1} is equal to {num2}.";
        }
    }
}