using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rent_a_car_similation.Models;
using rent_a_car_similation.Services;

namespace rent_a_car_similation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly ColorService _colorService;

        public ColorController(ColorService colorService)
        {
            _colorService = colorService;
        }

        // Tüm renkleri listeleme
        [HttpGet("GetAllColors")]
        public ActionResult<List<Color>> GetAllColors()
        {
            var colors = _colorService.GetAllColors();
            return Ok(colors);
        }

        // ID'ye göre renk getirme
        [HttpGet("GetColorById/{id}")]
        public ActionResult<Color> GetColorById(int id)
        {
            var color = _colorService.GetColorById(id);
            if (color == null)
                return NotFound();
            return Ok(color);
        }

        // Yeni renk ekleme
        [HttpPost("AddColor")]
        public IActionResult AddColor([FromBody] Color color)
        {
            _colorService.AddColor(color);
            return Ok();
        }

        // Renk güncelleme
        [HttpPut("UpdateColor")]
        public IActionResult UpdateColor([FromBody] Color color)
        {
            _colorService.UpdateColor(color);
            return Ok();
        }

        // Renk silme
        [HttpDelete("DeleteColor/{id}")]
        public IActionResult DeleteColor(int id)
        {
            _colorService.DeleteColor(id);
            return Ok();
        }
    }
}