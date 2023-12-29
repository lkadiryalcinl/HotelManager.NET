using HotelManager.DataAccessLayer.Abstract;
using HotelManager.DataAccessLayer.Concrete;
using HotelManager.DataAccessLayer.Repositories;
using HotelManager.EntityLayer.Concrete;

namespace HotelManager.DataAccessLayer.EntityFramework
{
    public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(Context context) : base(context)
        {
        }
    }
}
