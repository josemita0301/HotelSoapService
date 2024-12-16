using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSoapService.Models
{
    [Table("availability")]
    public class Availability
    {
        [Key]
        public int availability_id { get; set; }
        public int room_id { get; set; }
        public string room_type { get; set; }
        public DateTime available_date { get; set; }
        public string status { get; set; }
    }
}
