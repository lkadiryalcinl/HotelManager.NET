using HotelManager.DataAccessLayer.Abstract;
using HotelManager.DataAccessLayer.Concrete;
using HotelManager.DataAccessLayer.Repositories;
using HotelManager.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(Context context) : base(context)
        {
        }
    }
}
