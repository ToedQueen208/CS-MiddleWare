using CS_MiddleWare.Services;
using Microsoft.AspNetCore.Mvc;

namespace CS_MiddleWare.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class AdventurersControllers : ControllerBase
    {
        private AdventurersService service;

        public AdventurersControllers(AdventurersService sr)
        {
            service = sr;
        }

        [HttpGet]
        public IActionResult GetAdventurers()
        {
            var listOfAdventurers = service.GetAdventurers();
            return Ok(listOfAdventurers);
        }
    }
}
