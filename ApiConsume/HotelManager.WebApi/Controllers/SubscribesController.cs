using HotelManager.BusinessLayer.Abstract;
using HotelManager.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SubscribesController : ControllerBase
    {
        private readonly ISubscribeService _SubscribeService;

        public SubscribesController(ISubscribeService SubscribeService)
        {
            _SubscribeService = SubscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var list = _SubscribeService.TGetList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var Subscribe = _SubscribeService.TGetByID(id);
            return Ok(Subscribe);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.TInsert(Subscribe);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var Subscribe = _SubscribeService.TGetByID(id);
            _SubscribeService.TDelete(Subscribe);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe Subscribe)
        {
            _SubscribeService.TUpdate(Subscribe);
            return Ok();
        }
    }
}
