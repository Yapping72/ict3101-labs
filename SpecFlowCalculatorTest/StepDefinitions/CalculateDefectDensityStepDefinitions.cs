using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class CalculateDefectDensityStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public CalculateDefectDensityStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculator = calculatorContext.Calculator; // Assign 
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press defect density")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDefectDensity(double p0, double p1)
        {
            _result = _calculator.CalculateDefectDensity(p0, p1); 
        }

        [Then(@"the defect density should be (.*)")]
        public void ThenTheDefectDensityShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
