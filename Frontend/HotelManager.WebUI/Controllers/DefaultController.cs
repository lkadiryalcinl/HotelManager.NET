using HotelManager.WebUI.Dtos.ServiceDto;
using HotelManager.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelManager.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult _SubscribePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> _SubscribePartial(CreateSubscribeDto createSubscribeDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var client = _httpClientFactory.CreateClient(); 
            var data = JsonConvert.SerializeObject(createSubscribeDto);

            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var res = await client.PostAsync("http://localhost:12884/api/v1/Subscribes", content);

            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","Default");
            }
            return View();
        }
    }
}
