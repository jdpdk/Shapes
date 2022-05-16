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
    public class TriangleTest
    {
        [Theory]
        [InlineData(2, 2, 2, 1.7321)]
        [InlineData(4, 13, 13, 25.6905)]
        [InlineData(7, 16, 11, 31.9374)]
        public void Triangle_Calculate_Area(int a, int b, int c, double result)
        {
            //Arrange
            Triangle triangle = new Triangle();
            triangle.A = a;
            triangle.B = b;
            triangle.C = c;

            //Act
            double area = triangle.Area();

            //Assert
            area.Should().BeApproximately(result, 0.01F);
        }

        [Theory]
        [InlineData(2, 2, 2, 6)]
        [InlineData(4, 13, 13, 30)]
        [InlineData(7, 16, 11, 34)]
        public void Triangle_Calculate_Circumference(int a, int b, int c, double result)
        { 
            //Arrange
            Triangle triangle = new Triangle();
            triangle.A = a;
            triangle.B = b;
            triangle.C = c;


            //Act                           
            double circumference = triangle.Circumference();

            //Assert
            circumference.Should().BeApproximately(result, 0.01F);
        }
    }
}
