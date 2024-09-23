using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rent_a_car_similation.Models;
using rent_a_car_similation.Services;

namespace rent_a_car_similation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionController : ControllerBase
    {
        private readonly TransmissionService _transmissionService;

        public TransmissionController(TransmissionService transmissionService)
        {
            _transmissionService = transmissionService;
        }

        // Tüm vites tiplerini listeleme
        [HttpGet("GetAllTransmissions")]
        public ActionResult<List<Transmission>> GetAllTransmissions()
        {
            var transmissions = _transmissionService.GetAllTransmissions();
            return Ok(transmissions);
        }

        // ID'ye göre vites tipi getirme
        [HttpGet("GetTransmissionById/{id}")]
        public ActionResult<Transmission> GetTransmissionById(int id)
        {
            var transmission = _transmissionService.GetTransmissionById(id);
            if (transmission == null)
                return NotFound();
            return Ok(transmission);
        }

        // Yeni vites tipi ekleme
        [HttpPost("AddTransmission")]
        public IActionResult AddTransmission([FromBody] Transmission transmission)
        {
            _transmissionService.AddTransmission(transmission);
            return Ok();
        }

        // Vites tipi güncelleme
        [HttpPut("UpdateTransmission")]
        public IActionResult UpdateTransmission([FromBody] Transmission transmission)
        {
            _transmissionService.UpdateTransmission(transmission);
            return Ok();
        }

        // Vites tipi silme
        [HttpDelete("DeleteTransmission/{id}")]
        public IActionResult DeleteTransmission(int id)
        {
            _transmissionService.DeleteTransmission(id);
            return Ok();
        }
    }
}