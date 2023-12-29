using Autofac;
using HotelManager.BusinessLayer.Abstract;
using HotelManager.BusinessLayer.Concrete;
using HotelManager.DataAccessLayer.Abstract;
using HotelManager.DataAccessLayer.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RoomManager>().As<IRoomService>();
            builder.RegisterType<EfRoomDal>().As<IRoomDal>();

            builder.RegisterType<ServiceManager>().As<IServiceService>();
            builder.RegisterType<EfServiceDal>().As<IServiceDal>();

            builder.RegisterType<TestimonialManager>().As<ITestimonialService>();
            builder.RegisterType<EfTestimonialDal>().As<ITestimonialDal>();

            builder.RegisterType<StaffManager>().As<IStaffService>();
            builder.RegisterType<EfStaffDal>().As<IStaffDal>();

            builder.RegisterType<SubscribeManager>().As<ISubscribeService>();
            builder.RegisterType<EfSubscribeDal>().As<ISubscribeDal>();

            builder.RegisterType<AboutManager>().As<IAboutService>();
            builder.RegisterType<EfAboutDal>().As<IAboutDal>();

            builder.RegisterType<BookingManager>().As<IBookingService>();
            builder.RegisterType<EfBookingDal>().As<IBookingDal>();

            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();

            builder.RegisterType<SendMessageManager>().As<ISendMessageService>();
            builder.RegisterType<EfSendMessageDal>().As<ISendMessageDal>();
        }
    }
}

