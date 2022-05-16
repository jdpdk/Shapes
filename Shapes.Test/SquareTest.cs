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
    public class SquareTest
    {
        [Theory]
        [InlineData(1,1,1)]
        [InlineData(2,2,4)]
        [InlineData(42,89,3738)]
        public void Square_Calculate_Area(int height, int width, double result)
        {
            //Arrange
            Square square = new Square();
            square.Height = height;
            square.Width = width;

            //Act
            double area = square.Area();

            //Assert
            area.Should().BeApproximately(result, 0.01F);
        }

        [Theory]
        [InlineData(1, 1, 4)]
        [InlineData(2, 2, 8)]
        [InlineData(42, 89, 262)]
        public void Square_Calculate_Circumference(int height, int width, double result)
        {
            //Arrange
            Square square = new Square();
            square.Height = height;
            square.Width = width;

            //Act
            double circumference = square.Circumference();

            //Assert
            circumference.Should().BeApproximately(result, 0.01F);
        }
    }
}
