using HotelManager.DataAccessLayer.Abstract;
using HotelManager.DataAccessLayer.Concrete;
using HotelManager.DataAccessLayer.Repositories;
using HotelManager.EntityLayer.Concrete;

namespace HotelManager.DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServiceDal
    {
        public EfServiceDal(Context context) : base(context)
        {
        }
    }
}
