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
    public class WorkoutProgramTypesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public WorkoutProgramTypesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/WorkoutProgramTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkoutProgramType>>> GetWorkoutProgramTypes()
        {
            return await _context.WorkoutProgramTypes.ToListAsync();
        }

        // GET: api/WorkoutProgramTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutProgramType>> GetWorkoutProgramType(int id)
        {
            var workoutProgramType = await _context.WorkoutProgramTypes.FindAsync(id);

            if (workoutProgramType == null)
            {
                return NotFound();
            }

            return workoutProgramType;
        }

        // PUT: api/WorkoutProgramTypes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkoutProgramType(int id, WorkoutProgramType workoutProgramType)
        {
            if (id != workoutProgramType.Id)
            {
                return BadRequest();
            }

            _context.Entry(workoutProgramType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkoutProgramTypeExists(id))
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

        // POST: api/WorkoutProgramTypes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<WorkoutProgramType>> PostWorkoutProgramType(WorkoutProgramType workoutProgramType)
        {
            _context.WorkoutProgramTypes.Add(workoutProgramType);
            await _context.SaveChangesAsync();

            return workoutProgramType;
        }

        // DELETE: api/WorkoutProgramTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<WorkoutProgramType>> DeleteWorkoutProgramType(int id)
        {
            var workoutProgramType = await _context.WorkoutProgramTypes.FindAsync(id);
            if (workoutProgramType == null)
            {
                return NotFound();
            }

            _context.WorkoutProgramTypes.Remove(workoutProgramType);
            await _context.SaveChangesAsync();

            return workoutProgramType;
        }

        private bool WorkoutProgramTypeExists(int id)
        {
            return _context.WorkoutProgramTypes.Any(e => e.Id == id);
        }
    }
}
