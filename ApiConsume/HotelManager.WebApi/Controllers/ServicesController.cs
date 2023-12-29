using HotelManager.BusinessLayer.Abstract;
using HotelManager.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _ServiceService;

        public ServicesController(IServiceService ServiceService)
        {
            _ServiceService = ServiceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var list = _ServiceService.TGetList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var Service = _ServiceService.TGetByID(id);
            return Ok(Service);
        }

        [HttpPost]
        public IActionResult AddService(Service Service)
        {
            _ServiceService.TInsert(Service);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var Service = _ServiceService.TGetByID(id);
            _ServiceService.TDelete(Service);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service Service)
        {
            _ServiceService.TUpdate(Service);
            return Ok();
        }
    }
}
