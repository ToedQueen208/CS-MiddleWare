using CS_MiddleWare.Services;
using Microsoft.AspNetCore.Mvc;

namespace CS_MiddleWare.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class AdventurersController : ControllerBase
    {
        private AdventurersService service;

        public AdventurersController(AdventurersService sr)
        {
            service = sr;
        }

        [HttpGet]
        public IActionResult GetAdventurers()
        {
            var listOfAdventurers = service.GetAdventurers();
            return Ok(listOfAdventurers);
        }

        [HttpPost]

        public IActionResult PostAdventurer(Adventurer ad)
        {

            return Ok(service.addAdventurer(ad));
        }

    }
}
