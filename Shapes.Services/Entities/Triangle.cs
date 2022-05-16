using Shapes.Services.Interfaces;

namespace Shapes.Services
{
    public class Triangle: IArea, ICircumference
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public double Area()
        {

            double semiPerimeter = (A + B + C) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter -C ));
            return area;
        }

        public double Circumference()
        {
            return A + B + C;
        }
    }
}
