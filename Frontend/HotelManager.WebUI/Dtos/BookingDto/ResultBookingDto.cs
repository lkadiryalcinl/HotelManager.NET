using System.ComponentModel.DataAnnotations;

namespace HotelManager.WebUI.Dtos.BookingDto
{
    public class ResultBookingDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int RoomType { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
