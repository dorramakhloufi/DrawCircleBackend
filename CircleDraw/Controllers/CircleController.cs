using CircleDraw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CircleDraw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CircleController : ControllerBase
    {
        private readonly CircleContext _context;

        public CircleController(CircleContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddCircle(Circle circle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            circle.TimeOfSubmission = DateTime.Now;
            _context.Circles.Add(circle);
            await _context.SaveChangesAsync();

            return Ok(circle);
        }

        

        // CircleController.cs
        [HttpGet("/api/circle/{setId}")]
        public async Task<IActionResult> GetCirclesBySetId(int setId)
        {
            try
            {
                var circles = await _context.Circles.Where(c => c.SetId == setId).ToListAsync();
                return Ok(circles);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

    }
}
