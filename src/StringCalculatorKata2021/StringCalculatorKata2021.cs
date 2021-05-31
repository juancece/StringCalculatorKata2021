using System;
using System.Collections.Generic;
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

            var delimiters = new List<char> {',', '\n'};

            var stringinput = numbers;

            if (stringinput.StartsWith("//"))
            {
                var splitInput = stringinput.Split('\n');

                var newDelimeter = splitInput.First().Trim('/');

                stringinput = String.Join('\n', splitInput.Skip(1));

                delimiters.Add(Convert.ToChar(newDelimeter));
            }

            var numberList = stringinput.Split(delimiters.ToArray())
                .Select(x => int.Parse(x));

            var negatives = numberList.Where(x => x < 0);

            if (negatives.Any())
            {
                string negativeString = String.Join(',', negatives.Select(x => x.ToString()));

                throw new Exception($"Negatives not allowed: {negativeString}");
            }

            var result = numberList
                .Where(n => n <= 1000)
                .Sum();

            return result;

        }
    }
}
