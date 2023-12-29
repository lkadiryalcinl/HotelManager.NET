using HotelManager.WebUI.Dtos.BookingDto;
using HotelManager.WebUI.Dtos.ContactDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelManager.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDto createContactDto)
        {
            createContactDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(createContactDto);

            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:12884/api/v1/Contacts", content);
            return RedirectToAction("Index", "Contact");
        }
    }
}
