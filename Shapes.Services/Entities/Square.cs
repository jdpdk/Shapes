using Shapes.Services.Interfaces;

namespace Shapes.Services
{
    public class Square : IArea, ICircumference
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double Circumference()
        {
            return (Width + Height) * 2;
        }
    }
}