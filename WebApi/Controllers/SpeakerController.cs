using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("Policy")]
    public class SpeakerController : ControllerBase
    {
        private readonly SpeakerDbContext _context;

        public SpeakerController(SpeakerDbContext context)
        {
            _context = context;
        }

        // GET: api/Speaker
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Speaker>>> Getspeakers()
        {
            return await _context.speakers.ToListAsync();
        }

        // GET: api/Speaker/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Speaker>> GetSpeaker(string id)
        {
            var speaker = await _context.speakers.FindAsync(id);

            if (speaker == null)
            {
                return NotFound();
            }

            return speaker;
        }

        // PUT: api/Speaker/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpeaker(string id, Speaker speaker)
        {
            if (id != speaker.speakerId)
            {
                return BadRequest();
            }

            _context.Entry(speaker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpeakerExists(id))
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

        // POST: api/Speaker
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Speaker>> PostSpeaker(Speaker speaker)
        {
            _context.speakers.Add(speaker);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SpeakerExists(speaker.speakerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSpeaker", new { id = speaker.speakerId }, speaker);
        }

        // DELETE: api/Speaker/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Speaker>> DeleteSpeaker(string id)
        {
            var speaker = await _context.speakers.FindAsync(id);
            if (speaker == null)
            {
                return NotFound();
            }

            _context.speakers.Remove(speaker);
            await _context.SaveChangesAsync();

            return speaker;
        }

        private bool SpeakerExists(string id)
        {
            return _context.speakers.Any(e => e.speakerId == id);
        }
    }
}
