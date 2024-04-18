using CircleDraw.Models;
using Microsoft.EntityFrameworkCore;

namespace CircleDraw.Services
{
    public class CircleService
    {
        private readonly CircleContext _context;

        public CircleService(CircleContext context)
        {
            _context = context;
        }

        public async Task<Circle> AddCircleAsync(Circle circle)
        {
            circle.TimeOfSubmission = DateTime.Now;
            _context.Circles.Add(circle);
            await _context.SaveChangesAsync();
            return circle;
        }

        public async Task<List<Circle>> GetCirclesAsync(int setId)
        {
            return await _context.Circles.Where(c => c.SetId == setId).ToListAsync();
        }
    }
}
