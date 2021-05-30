using System;
using System.Linq;

namespace StringCalculatorKata2021
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            if (numbers.Contains(','))
            {
                var result = numbers.Split(',')
                    .Select(x => int.Parse(x))
                    .Sum();
                return result;
            }

            return int.Parse(numbers);
        }
    }
}
