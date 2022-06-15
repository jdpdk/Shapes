using Microsoft.AspNetCore.Mvc;
using Shapes.Services.DTO;
using Shapes.Services.Interfaces;
using Shapes.Services.Services;

namespace Shapes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapeController : ControllerBase
    {
        private readonly IAreaService areaService;

        public ShapeController(IAreaService areaService)
        {
            this.areaService = areaService;
        }

        [HttpPost("Area")]
        public IActionResult Get([FromBody] ShapesDTO shapesDTO)
        {
            var area = areaService.CalculateArea(shapesDTO);
            return Ok(area);
        }
    }
}