using LifestyleSurveyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LifestyleSurveyApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Survey> Survey { get; set; }
    }
}
