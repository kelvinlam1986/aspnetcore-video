using AspNetCoreVideo.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreVideo.Data
{
    public class VideoDbContext : DbContext
    {
        public VideoDbContext(DbContextOptions<VideoDbContext> options) : base(options)
        {
        }

        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
