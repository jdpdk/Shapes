using Microsoft.AspNetCore.Mvc;
using Shapes.Services.DTO;
using Shapes.Services.Services;

namespace Shapes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapeController : ControllerBase
    {
       
        public ShapeController()
        {
        }

        [HttpPost("Area")]
        public IActionResult Get([FromBody] ShapesDTO shapesDTO, [FromServices] AreaService areaService)
        {
            var area = areaService.CalculateArea(shapesDTO);
            return Ok(area);
        }
    }
}