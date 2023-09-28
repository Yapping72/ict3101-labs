using ICT3101_Calculator;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act
            double result = _calculator.Subtract(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(-10));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            // Act
            double result = _calculator.Multiply(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToQuotient()
        {
            // Act
            double result = _calculator.Divide(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(0.5));
        }

        [Test]
        public void DoOperation_WhenAdding_ReturnsSum()
        {
            // Act
            double result = _calculator.DoOperation(5, 10, "a");
            // Assert
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void DoOperation_WhenSubtracting_ReturnsDifference()
        {
            // Act
            double result = _calculator.DoOperation(15, 5, "s");
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]

        public void DoOperation_WhenMultiplying_ReturnsProduct()
        {
            // Act
            double result = _calculator.DoOperation(3, 5, "m");
            // Assert
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void DoOperation_WhenDividing_ReturnsQuotient()
        {
            // Act
            double result = _calculator.DoOperation(20, 10, "d");
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        /*
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }
        */

        [Test]
        public void CalculateTriangleArea_WithPositiveHeightAndLength_ReturnsCorrectArea()
        {
            // Arrange
            double height = 5;
            double length = 8;
            double expectedArea = 20; // (1/2) * height * length

            // Act
            double result = _calculator.CalculateTriangleArea(height, length);

            // Assert
            Assert.That(result, Is.EqualTo(expectedArea));
        }

        [Test]
        public void CalculateTriangleArea_WithNegativeHeight_ThrowsArgumentException()
        {
            // Arrange
            double height = -5;
            double length = 8;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalculateTriangleArea(height, length));
        }

        [Test]
        public void CalculateTriangleArea_WithNegativeLength_ThrowsArgumentException()
        {
            // Arrange
            double height = 5;
            double length = -8;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalculateTriangleArea(height, length));
        }

        [Test]
        public void CalculateCircleArea_WithPositiveRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 4;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            // Act
            double result = _calculator.CalculateCircleArea(radius);

            // Assert
            Assert.That(result, Is.EqualTo(expectedArea));
        }

        [Test]
        public void CalculateCircleArea_WithNegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = -4;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalculateCircleArea(radius));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
    }
}