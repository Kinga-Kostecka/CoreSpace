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

        // 1. GET: api/Reservations (Lista wszystkich)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations()
        {
            return await _context.Reservations.ToListAsync();
        }

        // 2. GET: api/Reservations/5 (Szczegóły)
        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);

            if (reservation == null) return NotFound();

            return reservation;
        }

        // 3. POST: api/Reservations (Dodanie nowej)
        [HttpPost]
        public async Task<ActionResult<Reservation>> PostReservation(Reservation reservation)
        {
            [span_3](start_span)[span_4](start_span);
            if (string.IsNullOrEmpty(reservation.RoomName))
                return BadRequest("Nazwa sali jest wymagana.");

            _context.Reservations.Add(reservation);
            await _context.SaveAsync();

            return CreatedAtAction(nameof(GetReservation), new { id = reservation.Id }, reservation);
        }

        // 4. PUT: api/Reservations/5 (Edycja)
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservation(int id, Reservation reservation)
        {
            if (id != reservation.Id) return BadRequest();

            _context.Entry(reservation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Reservations.Any(e => e.Id == id)) return NotFound();
                else throw;
            }

            return NoContent();
        }

        // 5. DELETE: api/Reservations/5 (Usuwanie)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null) return NotFound();

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
