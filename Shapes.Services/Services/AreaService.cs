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
        public void CalculateArea(IEnumerable<IArea> shapes)
        {
            double result = 0.0;
            foreach (IArea area in shapes)
            {
                result += area.Area();
            }
        }
    }

}
