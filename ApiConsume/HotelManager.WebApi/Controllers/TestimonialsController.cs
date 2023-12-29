using HotelManager.BusinessLayer.Abstract;
using HotelManager.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelManager.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;

        public TestimonialsController(ITestimonialService TestimonialService)
        {
            _TestimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var list = _TestimonialService.TGetList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var Testimonial = _TestimonialService.TGetByID(id);
            return Ok(Testimonial);
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial Testimonial)
        {
            _TestimonialService.TInsert(Testimonial);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var Testimonial = _TestimonialService.TGetByID(id);
            _TestimonialService.TDelete(Testimonial);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial Testimonial)
        {
            _TestimonialService.TUpdate(Testimonial);
            return Ok();
        }
    }
}
