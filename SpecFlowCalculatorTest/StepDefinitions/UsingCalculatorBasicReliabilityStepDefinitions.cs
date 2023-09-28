using ICT3101_Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private readonly Calculator _calculator;
        private double _result;

        public UsingCalculatorBasicReliabilityStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculator = calculatorContext.Calculator;
        }


        [When(@"I have entered initial failure as (.*) total failure as (.*) average failure as (.*) and press CurrentFailureIntensity")]
        public void WhenIHaveEnteredInitialFailureAsTotalFailureAsAverageFailureAndPressCurrentFailureIntensity(double initialFailure, double totalFailure, double averageFailure)
        {
            _result = _calculator.CurrentFailureIntensity(initialFailure, averageFailure, totalFailure);
        }


        [When(@"I have entered initial failure as (.*) total failure as (.*) time as (.*) and press AverageNumberOfExpectedFailures")]
        public void WhenIHaveEnteredInitialFailureAsTotalFailureAsTimeAsAndPressAverageNumberOfExpectedFailures(double initialFailure, double totalFailure, double time)
        {
            _result = _calculator.AverageNumberOfExpectedFailures(totalFailure, initialFailure, time);
        }

        [Then(@"the BasicReliability result should be (.*)")]
        public void ThenTheBasicReliabilityResultShouldBe(double expected)
        {
            Assert.AreEqual(expected, _result);  
        }
    }
}
