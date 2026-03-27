using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreSpace.Data;
using CoreSpace.Models;

namespace CoreSpace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReservationsController(AppDbContext context)
        {
            _context = context;
        }

        // 5.1. Uaktualniona metoda GetAll (mapowanie na DTO)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReservationReadDto>>> GetReservations()
        {
            var reservations = await _context.Reservations.ToListAsync();

            // Ręczne mapowanie na listę DTO
            var reservationsDto = reservations.Select(r => new ReservationReadDto
            {
                Id = r.Id,
                RoomName = r.RoomName,
                ReservedBy = r.ReservedBy,
                StartTime = r.StartTime.ToString("yyyy-MM-dd HH:mm"),
                EndTime = r.EndTime.ToString("yyyy-MM-dd HH:mm"),
                Status = r.Status
            }).ToList();

            return Ok(reservationsDto);
        }

        // 5.1. Uaktualniona metoda GetById (zwraca DTO)
        [HttpGet("{id}")]
        public async Task<ActionResult<ReservationReadDto>> GetReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);

            if (reservation == null)
            {
                return NotFound();
            }

            var reservationDto = new ReservationReadDto
            {
                Id = reservation.Id,
                RoomName = reservation.RoomName,
                ReservedBy = reservation.ReservedBy,
                StartTime = reservation.StartTime.ToString("yyyy-MM-dd HH:mm"),
                EndTime = reservation.EndTime.ToString("yyyy-MM-dd HH:mm"),
                Status = reservation.Status
            };

            return Ok(reservationDto);
        }

        // Metoda POST (do testu zapisu z punktu 4)
        [HttpPost]
        public async Task<ActionResult<Reservation>> PostReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetReservation), new { id = reservation.Id }, reservation);
        }
    }
}
