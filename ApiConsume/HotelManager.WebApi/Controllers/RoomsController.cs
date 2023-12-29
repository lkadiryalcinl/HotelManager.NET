using AutoMapper;
using HotelManager.BusinessLayer.Abstract;
using HotelManager.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _RoomService;

        public RoomsController(IRoomService roomService)
        {
            _RoomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var list = _RoomService.TGetList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var Room = _RoomService.TGetByID(id);
            return Ok(Room);
        }

        [HttpPost]
        public IActionResult AddRoom(Room Room)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            _RoomService.TInsert(Room);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var room = _RoomService.TGetByID(id);
            _RoomService.TDelete(room);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room Room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _RoomService.TUpdate(Room);
            return Ok();
        }
    }
}
