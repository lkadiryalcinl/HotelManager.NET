using System.ComponentModel.DataAnnotations;

namespace HotelManager.WebUI.Dtos.BookingDto
{
    public class CreateBookingDto
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomType { get; set; }
        public string SpecialRequest { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public bool Status { get; set; } = false;
    }
}
