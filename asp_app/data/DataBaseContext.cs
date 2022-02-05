using Microsoft.EntityFrameworkCore;

namespace asp_app.data
{
    public class DataBaseContext:DbContext //Dbcontext : type de la classe(extend Dbcontext)
    {
        public DataBaseContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
    }
}
