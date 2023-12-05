using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinylDatabaseApi.Data;

namespace VinylDatabaseApi.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class Vinyls1Controller : ControllerBase
    {
        private readonly VinylDatabaseApiContext _context;

        public Vinyls1Controller(VinylDatabaseApiContext context)
        {
            _context = context;
            //_context.Database.EnsureDeleted();
            //_context.Database.EnsureCreated();
            //_context.SaveChanges();
            //_context.Add(new Vinyl
            //{
            //    Title = "Title",
            //    Artist = "artist",
            //    NumberOfLps = 10,
            //    NumberOfTracks = 10,
            //    Price = 10,
            //    ReleaseDate = DateTime.Now,
            //    ImageLink = "link",
            //    Tracks = new List<Track>
            //    {
            //        new Track
            //        {
            //            Title = "track1",
            //            Length = 3.45f,
            //        }
            //    }
            //});
            //_context.SaveChanges();]
            //foreach (var item in SeedData.SeedDataList)
            //{
            //    _context.Vinyl.Add(item);
            //    _context.SaveChanges();
            //}

            //foreach (var vinyl in _context.Vinyl)
            //{
            //    Console.WriteLine($"Vinyl: {vinyl.Title}");
            //    foreach (var track in vinyl.Tracks)
            //    {
            //        Console.WriteLine($"Track: {track.Title}");
            //        Console.WriteLine($"Track: {TimeFormatter(track.Length)}");
            //    }
            //}
        }

        // GET: api/Vinyls1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vinyl>>> GetVinyl()
        {
            return await _context.Vinyl.ToListAsync();
        }

        // GET: api/Vinyls1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vinyl>> GetVinyl(int id)
        {
            var vinyl = await _context.Vinyl.FindAsync(id);

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
            if (id != vinyl.VinylId)
            {
                return BadRequest();
            }

            _context.Entry(vinyl).State = EntityState.Modified;

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
            //vinyl.Tracks.AddRange(vinyl.Tracks);
            //_context.Vinyl.Add(vinyl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVinyl", new { id = vinyl.VinylId }, vinyl);
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
            return _context.Vinyl.Any(e => e.VinylId == id);
        }
    }
}
