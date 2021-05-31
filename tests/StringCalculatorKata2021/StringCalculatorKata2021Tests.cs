using System;
using StringCalculatorKata2021;
using Xunit;

namespace StringCalculatorKata2021.Tests
{
    public class StringCalculatorKata2021Tests
    {
        private StringCalculator _stringCalculator = new StringCalculator();
        [Fact]
        public void Returns0GivenEmptyString()
        {
            var result = _stringCalculator.Add("");

            Assert.Equal(0, result);

        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void ReturnsNumberGivenStringWithOneNumber(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData("1, 2", 3)]
        [InlineData("2, 3", 5)]
        public void ReturnsSumGivenStringWithTwoSeparatedCommaNumbers(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData("1, 2, 3", 6)]
        [InlineData("2, 3, 4", 9)]
        public void ReturnsSumGivenStringWithThreeSeparatedCommaNumbers(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData("1\n2, 3", 6)]
        [InlineData("1\n2\n3", 6)]
        [InlineData("1,2\n3", 6)]
        public void ReturnsSumGivenStringWithThreeSeparatedCommaOrNewLineNumbers(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData("//;\n1;2;3", 6)]
        public void ReturnsSumGivenStringWithCustomDelimiter(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData("-1,2", "Negatives not allowed: -1")]
        [InlineData("-1,-2", "Negatives not allowed: -1,-2")]
        public void ThrowsNegativeNumbersInput(string numbers, string expectedMessage)
        {
            Action action = () => _stringCalculator.Add(numbers);

            var ex = Assert.Throws<Exception>(action);

            Assert.Equal(expectedMessage, ex.Message);

        }

        [Theory]
        [InlineData("1, 2, 3000", 3)]
        [InlineData("1001, 2", 2)]
        [InlineData("1000, 2", 1002)]
        public void ReturnsSumGivenStringIgnoringValuesOver1000(string numbers, int expectedResult)
        {
            var result = _stringCalculator.Add(numbers);

            Assert.Equal(expectedResult, result);

        }
    }
}
