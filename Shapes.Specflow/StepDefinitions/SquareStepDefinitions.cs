using Shapes.Services;

namespace Shapes.Specflow.StepDefinitions
{
    [Binding]
    public sealed class SquareStepDefinitions
    {
        private readonly Square square;
        private double _result;

        public SquareStepDefinitions()
        {
            square = new Square();
        }

        [Given("the height is (.*)")]
        public void GivenTheHeightIs(int number)
        {
            square.Height = number;
        }

        [Given("the width is (.*)")] 
        public void GivenWidthIs(int number)
        {
            square.Width = number;
        }

        [When("the area is calculated")]
        public void WhenTheAreaIsCalculated()
        {
            _result = square.Area();
        }

        [When("the circumference is calculated")]
        public void WhenTheCircumferenceIsCalculated()
        {
            _result = square.Circumference();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}