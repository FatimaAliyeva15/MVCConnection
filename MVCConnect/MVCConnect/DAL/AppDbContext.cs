using Microsoft.EntityFrameworkCore;
using MVCConnect.Models;

namespace MVCConnect.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        DbSet<Work> Works { get; set; }
        DbSet<RecentWork> RecentWorks { get; set;}
    }
}
