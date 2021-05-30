using System;

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
            return int.Parse(numbers);
        }
    }
}
