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

            var delimiters = new[] {',', '\n'};

            var result = numbers.Split(delimiters)
                .Select(x => int.Parse(x))
                .Sum();
            return result;

        }
    }
}
