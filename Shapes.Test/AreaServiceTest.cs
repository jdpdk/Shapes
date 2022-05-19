using FluentAssertions;
using NSubstitute;
using Shapes.Services.Interfaces;
using Shapes.Services.Services;
using Shapes.Test.ClassData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Shapes.Test
{
    public class AreaServiceTest
    {
        [Fact]
        public void Return_0_if_list_is_empty()
        {
            //Arrange
            List<IArea> shapes = new List<IArea>();
            AreaService sut = new AreaService();

            //Act
            double result = sut.CalculateArea(shapes);

            //Assert
            result.Should().Be(0);
        }

        [Fact]
        public void Test_with_mock()
        {
            //Arrange
            List<IArea> shapes = new List<IArea>();
            var area = Substitute.For<IArea>();
            area.Area().Returns(10.0);
            shapes.Add(area);

            AreaService sut = new AreaService();

            //Act
            double result = sut.CalculateArea(shapes);

            //Assert
            result.Should().Be(10);
        }


        [Theory]
        [ClassData(typeof(AreaServiceTestData))]
        public void CanAddTheoryClassData(IEnumerable<IArea> shapes, double expected)
        {
            //Arrange
            AreaService sut = new AreaService();

            //Act
            double result = sut.CalculateArea(shapes);

            //Assert
            result.Should().BeApproximately(expected, 0.02F);

        }
    }
}
