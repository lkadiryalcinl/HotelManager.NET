using HotelManager.DataAccessLayer.Abstract;
using HotelManager.DataAccessLayer.Concrete;
using HotelManager.DataAccessLayer.Repositories;
using HotelManager.EntityLayer.Concrete;

namespace HotelManager.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }
    }
}
