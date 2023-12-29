using HotelManager.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelManager.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            createBookingDto.CheckIn = DateTime.Parse(createBookingDto.CheckIn.ToShortDateString());
            createBookingDto.CheckOut = DateTime.Parse(createBookingDto.CheckOut.ToShortDateString());

            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(createBookingDto);

            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:12884/api/v1/Bookings", content);
            return RedirectToAction("Index","Booking");
        }
    }
}
