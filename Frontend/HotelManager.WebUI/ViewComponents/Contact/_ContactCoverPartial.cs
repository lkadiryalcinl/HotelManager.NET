using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebUI.ViewComponents.Contact
{
    public class _ContactCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}