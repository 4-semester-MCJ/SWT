using NUnit.Framework;
using CalculatorNamespace; // Ensure this namespace is correct


namespace CalculatorTestNamespace
{
    [TestFixture] // This is a NUnit attribute that tells the test runner that this is a test class 
    public class UnitTest
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_CorrectResult()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            var result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5));

        }
        [Test]
        public void Subtract_TwoNumbers_CorrectResult()
        {
            // Arrange
            int a = 10;
            int b = 5;

            // Act
            var result = _calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5));

        }
        [Test]
        public void Multiply_TwoNumbers_CorrectResult()
        {
            // Arrange
            int a = 2;
            int b = 4;

            // Act
            var result = _calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));

        }
        [Test]
        public void Power_TwoNumbers_CorrectResult()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            var result = _calculator.Power(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));

        }
    }
}
