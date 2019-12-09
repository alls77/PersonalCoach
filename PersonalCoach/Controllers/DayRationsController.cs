using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCoach.Models;
using PersonalCoach.Models.Diets;

namespace PersonalCoach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DayRationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public DayRationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/DayRations?dayCount=7&calories=2000
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DayRation>>> GetDayRations([FromQuery]int dayCount=7, [FromQuery]int calories=2000)
        {
            var randomRations = await _context.DayRations.Where(i => i.calories == calories)
                .Include(i => i.DayRationMeals).Take(dayCount).ToListAsync();
            return randomRations;
        }

        // GET: api/DayRations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DayRation>> GetDayRation(int id)
        {
            var dayRation = await _context.DayRations.FindAsync(id);

            if (dayRation == null)
            {
                return NotFound();
            }

            return dayRation;
        }

        // PUT: api/DayRations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDayRation(int id, DayRation dayRation)
        {
            if (id != dayRation.Id)
            {
                return BadRequest();
            }

            _context.Entry(dayRation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DayRationExists(id))
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

        // POST: api/DayRations
        [HttpPost]
        public async Task<ActionResult<DayRation>> PostDayRation(DayRation dayRation)
        {
            _context.DayRations.Add(dayRation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDayRation", new { id = dayRation.Id }, dayRation);
        }

        // DELETE: api/DayRations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DayRation>> DeleteDayRation(int id)
        {
            var dayRation = await _context.DayRations.FindAsync(id);
            if (dayRation == null)
            {
                return NotFound();
            }

            _context.DayRations.Remove(dayRation);
            await _context.SaveChangesAsync();

            return dayRation;
        }

        private bool DayRationExists(int id)
        {
            return _context.DayRations.Any(e => e.Id == id);
        }
    }
}
