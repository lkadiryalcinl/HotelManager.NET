using HotelManager.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelManager.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var res = await client.GetAsync("http://localhost:12884/api/v1/Bookings");

            if (res.IsSuccessStatusCode)
            {
                var data = await res.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(data);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> ApprovedBookingReservation(ApprovedBookingReservationDto approvedBookingReservationDto)
        {
            approvedBookingReservationDto.Status = true;

            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(approvedBookingReservationDto);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            var res = await client.PutAsync($"http://localhost:12884/api/v1/Bookings/", content);

            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
