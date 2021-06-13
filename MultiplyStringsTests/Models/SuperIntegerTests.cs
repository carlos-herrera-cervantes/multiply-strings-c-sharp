using MultiplyStringsDomain.Models;
using Xunit;

namespace MultiplyStringsTests.Models
{
    public class SuperIntegerTests
    {
        [Fact]
        public void MultiplyStrings_Should_Return_Correct_Number()
        {
            var number1 = "10";
            var number2 = "11";
            const string ExpectedResult = "110";

            string result = SuperInteger.MultiplyStrings(number1, number2);

            Assert.Equal(result, ExpectedResult);
        }
    }
}