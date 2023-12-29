using HotelManager.DataAccessLayer.Abstract;
using HotelManager.DataAccessLayer.Concrete;
using HotelManager.DataAccessLayer.Repositories;
using HotelManager.EntityLayer.Concrete;

namespace HotelManager.DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(Context context) : base(context)
        {
        }
    }
}
