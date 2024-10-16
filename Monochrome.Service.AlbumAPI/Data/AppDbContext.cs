using Microsoft.EntityFrameworkCore;
using Monochrome.Service.AlbumAPI.Model;

namespace Monochrome.Service.AlbumAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
        {
                
        }
        public DbSet<Song> Songs{ get; set; }
        public DbSet<SongMetadata> SongMetadata { get; set; }
    }
}
