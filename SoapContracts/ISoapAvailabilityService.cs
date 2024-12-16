using HotelSoapService.Models;
using System.ServiceModel;

namespace HotelSoapService.SoapContracts
{
    [ServiceContract]
    public interface ISoapAvailabilityService
    {
        [OperationContract]
        List<Availability> GetAvailableRooms(string roomType, string status, string startDate, string endDate);
    }
}
