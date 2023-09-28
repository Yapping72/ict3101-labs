using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class CalculateSSIStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public CalculateSSIStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculator = calculatorContext.Calculator; // Assign 
        }

        [When(@"I have entered (.*), (.*) and (.*) into the calculator and press SSI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSSI(double p0, double p1, double p2)
        {
            _result = _calculator.CalculateNewSSI(p0, p1, p2);
        }

        [Then(@"the SSI shiould be total (.*)")]
        public void ThenTheSSIShiouldBeTotal(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
