namespace HotelManager.WebUI.Dtos.RoomDto
{
    public class ResultRoomDto
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int RoomType { get; set; }
        public string RoomCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public int StarCount { get; set; }
        public int BedCount { get; set; }
        public int BathCount { get; set; }
        public bool Wifi { get; set; }
        public string Description { get; set; }
    }
}
