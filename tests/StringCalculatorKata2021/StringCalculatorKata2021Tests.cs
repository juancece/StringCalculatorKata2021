using StringCalculatorKata2021;
using Xunit;

namespace StringCalculatorKata2021.Tests
{
    public class StringCalculatorKata2021Tests
    {
        [Fact]
        public void Returns0GivenEmptyString()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("");

            Assert.Equal(0, result);

        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void ReturnsNumberGivenStringWithOneNumber(string numbers, int expectedResult)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData("1, 2", 3)]
        [InlineData("2, 3", 5)]
        public void ReturnsSumGivenStringWithTwoSeparatedCommaNumbers(string numbers, int expectedResult)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            Assert.Equal(expectedResult, result);

        }
    }
}
