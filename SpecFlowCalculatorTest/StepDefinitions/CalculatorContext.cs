using ICT3101_Calculator;

namespace SpecFlowCalculatorTest.StepDefinitions
{
    [Binding]
    public class CalculatorContext // POCO to share calculate context
    {
        public Calculator Calculator { get; private set; }
        public CalculatorContext()
        {
            Calculator = new Calculator();
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            
        }
    }
}
