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
    }
}
