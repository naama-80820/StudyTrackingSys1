using Microsoft.EntityFrameworkCore;
using StudyTrackingSys1.Data;
using StudyTrackingSys1.Models;

namespace StudyTrackingSys1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Masechet> Masechtot { get; set; }
        public DbSet<DafLine> DafLines { get; set; }
        public DbSet<StudyPlan> StudyPlans { get; set; }
        public DbSet<StudyProgress> StudyProgress { get; set; }
    }
}
