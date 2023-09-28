using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTest.StepDefinitions;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class DivisionStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public DivisionStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculator = calculatorContext.Calculator; // Assign 
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredDivideIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [Then(@"the division result equals (.*)")]
        public void ThenTheDivisionErrorShouldBeOnTheScreen(string expectedResult)
        {
            if (expectedResult == "positive_infinity")
            {
                Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
            }
            else
            {
                throw new ArgumentException($"Unknown expected result: {expectedResult}");
            }
        }

    }
}