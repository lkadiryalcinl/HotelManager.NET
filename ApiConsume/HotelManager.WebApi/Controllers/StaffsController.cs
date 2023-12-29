using HotelManager.BusinessLayer.Abstract;
using HotelManager.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService _StaffService;

        public StaffsController(IStaffService StaffService)
        {
            _StaffService = StaffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var list = _StaffService.TGetList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var Staff = _StaffService.TGetByID(id);
            return Ok(Staff);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff Staff)
        {
            _StaffService.TInsert(Staff);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var Staff = _StaffService.TGetByID(id);
            _StaffService.TDelete(Staff);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff Staff)
        {
            _StaffService.TUpdate(Staff);
            return Ok();
        }
    }
}
