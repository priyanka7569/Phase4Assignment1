using CalcLib;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class Calculator1StepDefinitions
    {
        private readonly ScenarioContext scenariocontext;
        private readonly Calculator calculator;
        private int result;
        public Calculator1StepDefinitions(ScenarioContext scenariocontext)
        {
            this.scenariocontext= scenariocontext;
            this.calculator= new Calculator();
        }
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            calculator.Num1 = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
           calculator.Num2= p0;
        }

        [When(@"the two numbers are Multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = calculator.Mul();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            result.Should().Be(p0);
        }

        [When(@"the two numbers are Subtracting")]
        public void WhenTheTwoNumbersAreSubtracting()
        {
            result = calculator.Sub();
        }

        [When(@"the two numbers are Dividing")]
        public void WhenTheTwoNumbersAreDividing()
        {
            result= calculator.Div();
        }
    }
}
