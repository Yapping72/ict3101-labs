using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTest.StepDefinitions;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculator = calculatorContext.Calculator; // Assign the initialized calculator 
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}