using ICT3101_Calculator;
using NUnit.Framework;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {
        private Calculator _calculator;
        private double _result;

        public UsingCalculatorAvailabilityStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculator = calculatorContext.Calculator; // Assign the initialized calculator 
        }


        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredMTTRAndMTTFIntoTheCalculatorAndPressMTBF(double p0, double p1)
        {
            _result = _calculator.MTBF(p0, p1);
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheMTBFResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            _result = _calculator.Availability(p0, p1);
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
