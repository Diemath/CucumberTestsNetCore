﻿using System;
using TechTalk.SpecFlow;
using Xunit;

namespace CucumberTestsNetCore.Calculator.XUnit
{
    [Binding]
    public class CalculatorSteps
    {
        private int result;
        private CucumberTestsNetCore.Calculator.Calculator calculator = new CucumberTestsNetCore.Calculator.Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.Equal(expectedResult, result);
        }
    }
}
