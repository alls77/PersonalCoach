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
    public class ExerciseWorkoutsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ExerciseWorkoutsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/ExerciseWorkouts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExerciseWorkout>>> GetExerciseWorkout()
        {
            return await _context.ExerciseWorkout.ToListAsync();
        }

        // GET: api/ExerciseWorkouts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExerciseWorkout>> GetExerciseWorkout(int id)
        {
            var exerciseWorkout = await _context.ExerciseWorkout.FindAsync(id);

            if (exerciseWorkout == null)
            {
                return NotFound();
            }

            return exerciseWorkout;
        }

        // PUT: api/ExerciseWorkouts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExerciseWorkout(int id, ExerciseWorkout exerciseWorkout)
        {
            if (id != exerciseWorkout.ExerciseId)
            {
                return BadRequest();
            }

            _context.Entry(exerciseWorkout).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExerciseWorkoutExists(id))
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

        // POST: api/ExerciseWorkouts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ExerciseWorkout>> PostExerciseWorkout(ExerciseWorkout exerciseWorkout)
        {
            _context.ExerciseWorkout.Add(exerciseWorkout);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ExerciseWorkoutExists(exerciseWorkout.ExerciseId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetExerciseWorkout", new { id = exerciseWorkout.ExerciseId }, exerciseWorkout);
        }

        // DELETE: api/ExerciseWorkouts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExerciseWorkout>> DeleteExerciseWorkout(int id)
        {
            var exerciseWorkout = await _context.ExerciseWorkout.FindAsync(id);
            if (exerciseWorkout == null)
            {
                return NotFound();
            }

            _context.ExerciseWorkout.Remove(exerciseWorkout);
            await _context.SaveChangesAsync();

            return exerciseWorkout;
        }

        private bool ExerciseWorkoutExists(int id)
        {
            return _context.ExerciseWorkout.Any(e => e.ExerciseId == id);
        }
    }
}
