using Microsoft.EntityFrameworkCore;

namespace MVC_19._01._24_.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated(); //Проверяет, существует ли база данных. Если она не существует - создаёт базу данных.
            
        }
    }
}
