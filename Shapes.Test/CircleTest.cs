using FluentAssertions;
using Shapes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shapes.Test
{
    public class CircleTest
    {
        [Theory]
        [InlineData(1, 3.14159)]
        [InlineData(2, 12.56637)]
        [InlineData(42, 5541.77)]
        public void Circle_Calculate_Area(int radius, double result)
        {
            //Arrange
            Circle circle = new Circle();
            circle.Radius = radius;

            //Act
            double area = circle.Area();

            //Assert
            area.Should().BeApproximately(result, 0.01F);
        }

        [Theory]
        [InlineData(1, 6.28319)]
        public void Circle_Calculate_Circumference(int radius, double result)
        {
            //Arrange
            Circle circle = new Circle();
            circle.Radius = radius;

            //Act
            double circumference = circle.Circumference();

            //Assert
            circumference.Should().BeApproximately(result, 0.01F);
        }
    }
}
