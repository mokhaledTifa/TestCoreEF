using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace TestCoreEF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<string> Summaries = new List<string>
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
       
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Count)]
            })
            .ToArray();
        }
        [HttpPost]
        public IActionResult Post(string? data)
        {
            if (data ==null)
            {
              return BadRequest("nitvaild");
            }
            Summaries.Add(data);
            return Ok("Done");
        }

        [HttpGet("GetSummaries")]
        public IActionResult GetSummaries()
        {
            if (Summaries.Count() <= 0)
            {
                return NotFound();
            }
            return Ok(Summaries.ToList());
        }
    }
}
