namespace HotelSoapService.Models
{
    public class AvailabilityRequest
    {
        public string RoomType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }

}
