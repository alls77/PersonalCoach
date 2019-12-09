using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCoach.Models;
using PersonalCoach.Models.Workouts;

namespace PersonalCoach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuscleGroupsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public MuscleGroupsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/MuscleGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MuscleGroup>>> GetMuscleGroups()
        {
            return await _context.MuscleGroups.ToListAsync();
        }

        // GET: api/MuscleGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MuscleGroup>> GetMuscleGroup(int id)
        {
            var muscleGroup = await _context.MuscleGroups.FindAsync(id);

            if (muscleGroup == null)
            {
                return NotFound();
            }

            return muscleGroup;
        }

        // PUT: api/MuscleGroups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMuscleGroup(int id, MuscleGroup muscleGroup)
        {
            if (id != muscleGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(muscleGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MuscleGroupExists(id))
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

        // POST: api/MuscleGroups
        [HttpPost]
        public async Task<ActionResult<MuscleGroup>> PostMuscleGroup(MuscleGroup muscleGroup)
        {
            _context.MuscleGroups.Add(muscleGroup);
            await _context.SaveChangesAsync();

            return muscleGroup;
        }

        // DELETE: api/MuscleGroups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MuscleGroup>> DeleteMuscleGroup(int id)
        {
            var muscleGroup = await _context.MuscleGroups.FindAsync(id);
            if (muscleGroup == null)
            {
                return NotFound();
            }

            _context.MuscleGroups.Remove(muscleGroup);
            await _context.SaveChangesAsync();

            return muscleGroup;
        }

        private bool MuscleGroupExists(int id)
        {
            return _context.MuscleGroups.Any(e => e.Id == id);
        }
    }
}
