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
    public class IngridientTypesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public IngridientTypesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/IngridientTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IngridientType>>> GetIngridientTypes()
        {
            return await _context.IngridientTypes.ToListAsync();
        }

        // GET: api/IngridientTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IngridientType>> GetIngridientType(int id)
        {
            var ingridientType = await _context.IngridientTypes.FindAsync(id);

            if (ingridientType == null)
            {
                return NotFound();
            }

            return ingridientType;
        }

        // PUT: api/IngridientTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngridientType(int id, IngridientType ingridientType)
        {
            if (id != ingridientType.Id)
            {
                return BadRequest();
            }

            _context.Entry(ingridientType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngridientTypeExists(id))
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

        // POST: api/IngridientTypes
        [HttpPost]
        public async Task<ActionResult<IngridientType>> PostIngridientType(IngridientType ingridientType)
        {
            _context.IngridientTypes.Add(ingridientType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIngridientType", new { id = ingridientType.Id }, ingridientType);
        }

        // DELETE: api/IngridientTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IngridientType>> DeleteIngridientType(int id)
        {
            var ingridientType = await _context.IngridientTypes.FindAsync(id);
            if (ingridientType == null)
            {
                return NotFound();
            }

            _context.IngridientTypes.Remove(ingridientType);
            await _context.SaveChangesAsync();

            return ingridientType;
        }

        private bool IngridientTypeExists(int id)
        {
            return _context.IngridientTypes.Any(e => e.Id == id);
        }
    }
}
