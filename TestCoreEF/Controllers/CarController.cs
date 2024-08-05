using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestCoreEF.Models;
using TestCoreEF.Repos.CarRepos;

namespace TestCoreEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepo _carRepo;

        public CarController(ICarRepo carRepo )
        {
           _carRepo = carRepo;
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //   // return Ok(Cars.ToList());
        //}
        [HttpPost]
        public IActionResult Post([FromBody] CarDB car)
        {
            _carRepo.createCar(car);
            return Ok();
        }
    }
}
