using ICT3101_Calculator;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorFactorialStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculator = calculatorContext.Calculator; // Assign 
        }

        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(double p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(double p0)
        {
            _result = _calculator.Factorial(p0);
        }
    }
}
