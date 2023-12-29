using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebUI.ViewComponents.Default
{
    public class _ReservationPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
