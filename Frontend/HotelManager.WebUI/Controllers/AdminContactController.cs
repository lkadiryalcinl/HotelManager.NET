using HotelManager.WebUI.Dtos.ContactDto;
using HotelManager.WebUI.Dtos.SendMessageDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelManager.WebUI.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Inbox()
        {
            var client = _httpClientFactory.CreateClient();
            var res = await client.GetAsync("http://localhost:12884/api/v1/Contacts");

            if (res.IsSuccessStatusCode)
            {
                var data = await res.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(data);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> SendBox()
        {
            var client = _httpClientFactory.CreateClient();
            var res = await client.GetAsync("http://localhost:12884/api/v1/SendMessages");

            if (res.IsSuccessStatusCode)
            {
                var data = await res.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSendBoxDto>>(data);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddSendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddSendMessage(CreateSendMessageDto model)
        {
            model.SenderName = "admin";
            model.SenderMail = "admin@hotelier.com";
            model.Date = DateTime.Now;

            var client = _httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(model);

            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var res = await client.PostAsync("http://localhost:12884/api/v1/SendMessages", content);

            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("SendBox");
            }
            return View();
        }

        public PartialViewResult SideBarAdminContactPartial()
        {
            return PartialView();
        }

        public PartialViewResult SideBarAdminContactCategoryPartial()
        {
            return PartialView();
        }

        public async Task<IActionResult> MessageDetailsBySendMessage(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var res = await client.GetAsync($"http://localhost:12884/api/v1/SendMessages/{id}");

            if (res.IsSuccessStatusCode)
            {
                var data = await res.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetSendMessageByIDDto>(data);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> MessageDetailsByContact(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var res = await client.GetAsync($"http://localhost:12884/api/v1/Contacts/{id}");

            if (res.IsSuccessStatusCode)
            {
                var data = await res.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetContactMessageByIDDto>(data);
                return View(values);
            }
            return View();
        }
    }
}
