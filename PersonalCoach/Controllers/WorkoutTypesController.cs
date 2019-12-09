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
    public class WorkoutTypesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public WorkoutTypesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/WorkoutTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkoutType>>> GetWorkoutTypes()
        {
            return await _context.WorkoutTypes.ToListAsync();
        }

        // GET: api/WorkoutTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutType>> GetWorkoutType(int id)
        {
            var workoutType = await _context.WorkoutTypes.FindAsync(id);

            if (workoutType == null)
            {
                return NotFound();
            }

            return workoutType;
        }

        // PUT: api/WorkoutTypes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkoutType(int id, WorkoutType workoutType)
        {
            if (id != workoutType.Id)
            {
                return BadRequest();
            }

            _context.Entry(workoutType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkoutTypeExists(id))
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

        // POST: api/WorkoutTypes
        [HttpPost]
        public async Task<ActionResult<WorkoutType>> PostWorkoutType(WorkoutType workoutType)
        {
            _context.WorkoutTypes.Add(workoutType);
            await _context.SaveChangesAsync();

            return workoutType;
        }

        // DELETE: api/WorkoutTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WorkoutType>> DeleteWorkoutType(int id)
        {
            var workoutType = await _context.WorkoutTypes.FindAsync(id);
            if (workoutType == null)
            {
                return NotFound();
            }

            _context.WorkoutTypes.Remove(workoutType);
            await _context.SaveChangesAsync();

            return workoutType;
        }

        private bool WorkoutTypeExists(int id)
        {
            return _context.WorkoutTypes.Any(e => e.Id == id);
        }
    }
}
