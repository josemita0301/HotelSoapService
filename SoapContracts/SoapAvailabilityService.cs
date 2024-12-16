using HotelSoapService.Data;
using HotelSoapService.Models;

namespace HotelSoapService.SoapContracts
{
    public class SoapAvailabilityService : ISoapAvailabilityService
    {
        private readonly ApplicationDbContext _context;

        public SoapAvailabilityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Availability> GetAvailableRooms(string roomType, string status, string startDate, string endDate)
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);

            return _context.Availabilities
                .Where(a => a.room_type == roomType &&
                            a.status == status &&
                            a.available_date >= start &&
                            a.available_date <= end)
                .ToList();
        }
    }
}
