using HotelManager.BusinessLayer.Abstract;
using HotelManager.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService BookingService)
        {
            _bookingService = BookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var list = _bookingService.TGetList();
            return Ok(list); 
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var Booking = _bookingService.TGetByID(id);
            return Ok(Booking);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking Booking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _bookingService.TInsert(Booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var Booking = _bookingService.TGetByID(id);
            _bookingService.TDelete(Booking);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking Booking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _bookingService.TUpdate(Booking);
            return Ok();
        }
    }
}
