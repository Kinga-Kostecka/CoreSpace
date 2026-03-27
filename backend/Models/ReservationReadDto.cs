using System;

namespace CoreSpace.Models
{
    public class ReservationReadDto
    {
        public int Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public string ReservedBy { get; set; } = string.Empty;
        public string StartTime { get; set; } = string.Empty;
        public string EndTime { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
