using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPICore.DatabaseContext
{
    public class WebAPIDbContext : DbContext
    {
        public WebAPIDbContext(DbContextOptions<WebAPIDbContext> options) : base(options)
        {
        }

        public DbSet<SampleAppProducts> sampleAppProducts { get; set; }


    }
}
