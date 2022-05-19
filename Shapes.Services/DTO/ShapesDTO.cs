using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Services.DTO
{
    public class ShapesDTO
    {
        public IEnumerable<Circle> Circles { get; set; } = new List<Circle>();
        public IEnumerable<Square> Squares { get; set; } = new List<Square>();
        public IEnumerable<Triangle> Triangles { get; set; } = new List<Triangle>();
    }
}
