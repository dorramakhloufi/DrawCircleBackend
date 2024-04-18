using CircleDraw.Models;
using Microsoft.EntityFrameworkCore;

namespace CircleDraw 
{
    public class CircleContext : DbContext
    {
        public DbSet<Circle> Circles { get; set; }

        public CircleContext(DbContextOptions options) : base(options)
        {

        }
    }
}
