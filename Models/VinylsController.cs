using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using VinylDatabaseApi.Data;

namespace VinylDatabaseApi.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class VinylsController : ControllerBase
    {
        private readonly VinylDatabaseApiContext _context;

        public VinylsController(VinylDatabaseApiContext context)
        {
            _context = context;
        }

        // GET: api/Vinyls1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vinyl>>> GetVinyl()
        {
            var vinyl = await _context.Vinyl
            .Include(track => track.Tracks)
            .ToListAsync();
            return vinyl;
        }

        // GET: api/Vinyls1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vinyl>> GetVinyl(int id)
        {
            var _ = await _context.Vinyl.Include(track => track.Tracks).ToListAsync();
            var vinyl = _.Find(x => x.Id == id);

            if (vinyl == null)
            {
                return NotFound();
            }

            return vinyl;
        }

        // PUT: api/Vinyls1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVinyl(int id, Vinyl vinyl)
        {
            if (id != vinyl.Id)
            {
                return BadRequest();
            }
            _context.Update(vinyl);
            //int[] ids = [];
            // note: you can add a new track if the id is not specified
            vinyl.Tracks.ForEach(track => _context.Tracks.Update(track));
            //_context.Tracks.Entry(vinyl).CurrentValues.SetValues(vinyl.Tracks);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VinylExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vinyls1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vinyl>> PostVinyl(Vinyl vinyl)
        {
            _context.Vinyl.Add(vinyl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVinyl", new { id = vinyl.Id }, vinyl);
        }

        // DELETE: api/Vinyls1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVinyl(int id)
        {
            var vinyl = await _context.Vinyl.FindAsync(id);
            if (vinyl == null)
            {
                return NotFound();
            }

            _context.Vinyl.Remove(vinyl);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VinylExists(int id)
        {
            return _context.Vinyl.Any(e => e.Id == id);
        }
    }
}
