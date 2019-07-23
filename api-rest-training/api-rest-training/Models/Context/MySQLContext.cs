using Microsoft.EntityFrameworkCore;

namespace api_rest_training.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext ()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
    }
}
