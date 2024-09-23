using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rent_a_car_similation.Models;
using rent_a_car_similation.Services;

namespace rent_a_car_similation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private readonly FuelService _fuelService;

        public FuelController(FuelService fuelService)
        {
            _fuelService = fuelService;
        }

        // Tüm yakıt tiplerini listeleme
        [HttpGet("GetAllFuels")]
        public ActionResult<List<Fuel>> GetAllFuels()
        {
            var fuels = _fuelService.GetAllFuels();
            return Ok(fuels);
        }

        // ID'ye göre yakıt tipi getirme
        [HttpGet("GetFuelById/{id}")]
        public ActionResult<Fuel> GetFuelById(int id)
        {
            var fuel = _fuelService.GetFuelById(id);
            if (fuel == null)
                return NotFound();
            return Ok(fuel);
        }

        // Yeni yakıt tipi ekleme
        [HttpPost("AddFuel")]
        public IActionResult AddFuel([FromBody] Fuel fuel)
        {
            _fuelService.AddFuel(fuel);
            return Ok();
        }

        // Yakıt tipi güncelleme
        [HttpPut("UpdateFuel")]
        public IActionResult UpdateFuel([FromBody] Fuel fuel)
        {
            _fuelService.UpdateFuel(fuel);
            return Ok();
        }

        // Yakıt tipi silme
        [HttpDelete("DeleteFuel/{id}")]
        public IActionResult DeleteFuel(int id)
        {
            _fuelService.DeleteFuel(id);
            return Ok();
        }
    }
}