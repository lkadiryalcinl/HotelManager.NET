using AutoMapper;
using HotelManager.EntityLayer.Concrete;
using HotelManager.WebUI.Dtos.AboutDto;
using HotelManager.WebUI.Dtos.BookingDto;
using HotelManager.WebUI.Dtos.ContactDto;
using HotelManager.WebUI.Dtos.LoginDto;
using HotelManager.WebUI.Dtos.RegisterDto;
using HotelManager.WebUI.Dtos.RoomDto;
using HotelManager.WebUI.Dtos.SendMessageDto;
using HotelManager.WebUI.Dtos.ServiceDto;
using HotelManager.WebUI.Dtos.StaffDto;
using HotelManager.WebUI.Dtos.SubscribeDto;
using HotelManager.WebUI.Dtos.TestimonialDto;

namespace HotelManager.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Room, CreateRoomDto>().ReverseMap();
            CreateMap<Room, UpdateRoomDto>().ReverseMap();
            CreateMap<Room, ResultRoomDto>().ReverseMap();

            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();

            CreateMap<Subscribe, CreateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, UpdateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, ResultSubscribeDto>().ReverseMap();

            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<Service, ResultServiceDto>().ReverseMap();

            CreateMap<Staff, CreateStaffDto>().ReverseMap();
            CreateMap<Staff, UpdateStaffDto>().ReverseMap();
            CreateMap<Staff, ResultStaffDto>().ReverseMap();

            CreateMap<AppUser, CreateNewUserDto>().ReverseMap();
            CreateMap<AppUser, LoginUserDto>().ReverseMap();

            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, ResultAboutDto>().ReverseMap();

            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, ApprovedBookingReservationDto>().ReverseMap();

            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, GetContactMessageByIDDto>().ReverseMap();

            CreateMap<SendMessage, GetSendMessageByIDDto>().ReverseMap();
            CreateMap<SendMessage, CreateSendMessageDto>().ReverseMap();
            CreateMap<SendMessage, ResultSendBoxDto>().ReverseMap();
        }
    }
}
