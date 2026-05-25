using Microsoft.AspNetCore.Mvc;

namespace weather_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet("{city}")]
        public IActionResult GetWeather(string city)
        {
            return Ok(new
            {
                city = city,
                temperature = "32°C",
                description = "Sunny"
            });
        }
    }
}