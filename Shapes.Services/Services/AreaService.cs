using Shapes.Services.DTO;
using Shapes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Services.Services
{
    public  class AreaService
    {
        public double CalculateArea(IEnumerable<IArea> shapes)
        {
            double totalArea = 0.0;
            foreach (IArea shape in shapes)
            {
                totalArea += shape.Area();
            }
            return totalArea;
        }

        public double CalculateArea(ShapesDTO shapes)
        {
            double area = 0.0;
            area += CalculateArea(shapes.Circles);
            area += CalculateArea(shapes.Squares);
            area += CalculateArea(shapes.Triangles);

            return area;
        }
    }

}
