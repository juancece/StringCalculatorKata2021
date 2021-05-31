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

            var result = stringinput.Split(delimiters.ToArray())
                .Select(x => int.Parse(x))
                .Sum();

            return result;

        }
    }
}
