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
        public void Returns1GivenStringWith1(string numbers, int expectedResult)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            Assert.Equal(expectedResult, result);

        }
    }
}
