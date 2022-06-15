using Shapes.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Services.Interfaces
{
    public interface IAreaService
    {
        public double CalculateArea(IEnumerable<IArea> shapes);
        public double CalculateArea(ShapesDTO shapes);
    }
}
