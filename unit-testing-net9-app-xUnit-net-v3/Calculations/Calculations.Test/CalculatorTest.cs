using Xunit;

namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact] // The fact attribute turns it into a test method
        public void Add_Given1and2_Returns3()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var sum = calculator.Add(1, 2);

            // Assert
            //Assert.True(sum == 3);
            Assert.Equal(3, sum); // comparing integers
        }

        [Fact]
        public void Add_GivenTwoDecimalValues_ReturnsSumWithTwoPlaces()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var sum = calculator.Add(1.5m, 1.2m);

            // Assert
            Assert.Equal(2.7m, sum); // comparing integers
        }
    }
}
