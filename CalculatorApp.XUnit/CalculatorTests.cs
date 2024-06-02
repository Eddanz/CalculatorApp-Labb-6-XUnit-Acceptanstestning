namespace CalculatorApp.XUnit
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1.0, 2.0, 3.0)]
        [InlineData(10.5, 5.5, 16.0)]
        [InlineData(-1.5, -2.5, -4.0)]
        [InlineData(100.0, 200.0, 300.0)]
        [InlineData(0.0, 0.0, 0.0)]
        public void Addition_ReturnsCorrectResult(decimal x, decimal y, decimal expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = Calculator.Addition(x, y);

            // Assert
            Assert.Equal(expected, result.Result);
        }

        [Theory]
        [InlineData(5.0, 3.0, 2.0)]
        [InlineData(10.5, 5.5, 5.0)]
        [InlineData(-1.5, -2.5, 1.0)]
        [InlineData(100.0, 50.0, 50.0)]
        [InlineData(0.0, 0.0, 0.0)]
        public void Subtraction_ReturnsCorrectResult(decimal x, decimal y, decimal expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = Calculator.Subtraction(x, y);

            // Assert
            Assert.Equal(expected, result.Result);
        }

        [Theory]
        [InlineData(2.0, 3.0, 6.0)]
        [InlineData(10.5, 2.0, 21.0)]
        [InlineData(-1.5, 2.0, -3.0)]
        [InlineData(100.0, 0.0, 0.0)]
        [InlineData(0.0, 0.0, 0.0)]
        public void Multiplication_ReturnsCorrectResult(decimal x, decimal y, decimal expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = Calculator.Multiplication(x, y);

            // Assert
            Assert.Equal(expected, result.Result);
        }

        [Theory]
        [InlineData(6.0, 3.0, 2.0)]
        [InlineData(21.0, 2.0, 10.5)]
        [InlineData(-3.0, 2.0, -1.5)]
        [InlineData(100.0, 25.0, 4.0)]
        [InlineData(0.0, 1.0, 0.0)]
        public void Division_ReturnsCorrectResult(decimal x, decimal y, decimal expected)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = Calculator.Division(x, y);

            // Assert
            Assert.Equal(expected, result.Result);
        }

        [Fact]
        public void Division_DivideByZero_ReturnsZero()
        {
            // Arrange
            var calculator = new Calculator();
            decimal x = 10.0m;
            decimal y = 0.0m;

            // Act
            var result = Calculator.Division(x, y);

            // Assert
            Assert.Equal(0, result.Result);
            Assert.Equal($"{x} / {y} = Cannot divide by zero.", result.Operation);
        }
    }
}