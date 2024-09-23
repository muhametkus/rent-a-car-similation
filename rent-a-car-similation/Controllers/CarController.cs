using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rent_a_car_similation.Models.DTO;
using rent_a_car_similation.Models;
using rent_a_car_similation.Services;

namespace rent_a_car_similation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarService _carService;

        public CarController(CarService carService)
        {
            _carService = carService;
        }

        // Tüm araç detaylarını getirme
        [HttpGet("GetAllDetails")]
        public ActionResult<List<CarDetailDTO>> GetAllDetails()
        {
            var carDetails = _carService.GetAllCarDetails();
            return Ok(carDetails);
        }

        // ID'ye göre araç detaylarını getirme
        [HttpGet("GetDetailById/{id}")]
        public ActionResult<CarDetailDTO> GetDetailById(int id)
        {
            var carDetail = _carService .GetDetailById(id);
            if (carDetail == null)
                return NotFound();
            return Ok(carDetail);
        }

        // Yeni araç ekleme
        [HttpPost("AddCar")]
        public IActionResult AddCar([FromBody] Car car)
        {
            _carService.AddCar(car);
            return Ok();
        }

        // Araç güncelleme
        [HttpPut("UpdateCar")]
        public IActionResult UpdateCar([FromBody] Car car)
        {
            _carService.UpdateCar(car);
            return Ok();
        }

        // Araç silme
        [HttpDelete("DeleteCar/{id}")]
        public IActionResult DeleteCar(int id)
        {
            _carService.DeleteCar(id);
            return Ok();
        }
    }

}