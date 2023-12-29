using HotelManager.BusinessLayer.Abstract;
using HotelManager.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var list = _aboutService.TGetList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var About = _aboutService.TGetByID(id);
            return Ok(About);
        }

        [HttpPost]
        public IActionResult AddAbout(About About)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _aboutService.TInsert(About);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var About = _aboutService.TGetByID(id);
            _aboutService.TDelete(About);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(About About)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _aboutService.TUpdate(About);
            return Ok();
        }
    }
}
