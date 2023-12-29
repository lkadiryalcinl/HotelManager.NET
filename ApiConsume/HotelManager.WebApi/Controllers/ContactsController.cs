using HotelManager.BusinessLayer.Abstract;
using HotelManager.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactsController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var list = _ContactService.TGetList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var Contact = _ContactService.TGetByID(id);
            return Ok(Contact);
        }

        [HttpPost]
        public IActionResult AddContact(Contact Contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _ContactService.TInsert(Contact);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var Contact = _ContactService.TGetByID(id);
            _ContactService.TDelete(Contact);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateContact(Contact Contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _ContactService.TUpdate(Contact);
            return Ok();
        }
    }
}
