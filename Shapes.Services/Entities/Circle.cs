using Shapes.Services.Interfaces;

namespace Shapes.Services
{
    public class Circle: IArea, ICircumference
    {
        public int Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Circumference()
        {
            return (2 * Math.PI) * Radius;
        }
    }
}
