using HotelManager.BusinessLayer.Abstract;
using HotelManager.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class SendMessagesController : ControllerBase
    {
        private readonly ISendMessageService _SendMessageservice;

        public SendMessagesController(ISendMessageService SendMessageservice)
        {
            _SendMessageservice = SendMessageservice;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var list = _SendMessageservice.TGetList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var SendMessage = _SendMessageservice.TGetByID(id);
            return Ok(SendMessage);
        }

        [HttpPost]
        public IActionResult AddSendMessage(SendMessage SendMessage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _SendMessageservice.TInsert(SendMessage);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSendMessage(int id)
        {
            var SendMessage = _SendMessageservice.TGetByID(id);
            _SendMessageservice.TDelete(SendMessage);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSendMessage(SendMessage SendMessage)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _SendMessageservice.TUpdate(SendMessage);
            return Ok();
        }
    }
}
