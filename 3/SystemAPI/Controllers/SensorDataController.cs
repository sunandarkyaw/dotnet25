using Microsoft.AspNetCore.Mvc;
using SystemAPI.Entity;
using SystemAPI.Model;
using Serilog;

namespace SystemAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class SensorDataController : ControllerBase
    {
        private readonly SensorDbContext _context;

        public SensorDataController(SensorDbContext context)
        {
            _context = context;
        }

        [HttpPost("PostSensorData")]
        public async Task<IActionResult> PostSensorData([FromBody] SensorData data)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.SensorData.Add(data);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An error occurred while saving sensor data.");

                return StatusCode(500, "An error occurred while saving sensor data.");
            }
        }
    }

}
