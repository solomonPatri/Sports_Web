using Sports_Web.Sport.Model;
using Microsoft.EntityFrameworkCore;

namespace Sports_Web.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public virtual DbSet<Sports> Sports
        {
            get;set;
        }

        
    }
}
