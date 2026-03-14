using System.ComponentModel.DataAnnotations;

namespace CoreSpace.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RoomName { get; set; } = string.Empty;

        [Required]
        public string ReservedBy { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
        public string Status { get; set; } = "Pending";
    }
}
