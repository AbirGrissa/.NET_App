using Microsoft.EntityFrameworkCore;

namespace asp_app.data
{
    public class DataBaseContext:DbContext //Dbcontext : type de la classe(extend Dbcontext)
    {
        public DataBaseContext(DbContextOptions options):base(options)
        {
        }
        protected override void OnModelCreating (ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Tunisia",
                    ShortName = "TN"
                },
                new Country
                {
                    Id = 2,
                    Name = "France",
                    ShortName = "FR"
                },
                new Country
                {
                    Id = 3,
                    Name = "Algeria",
                    ShortName = "DZ"
                }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel1",
                    Adress ="adress1",
                    Rating =1
                }
                );



        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        //remplir de la base de données 

    }
}
