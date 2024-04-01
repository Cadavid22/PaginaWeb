using Microsoft.EntityFrameworkCore;
using PaginaWeb.Shared.Entities;


namespace PaginaWeb.backend.Date
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<MyTask> MyTasks { get; set; }
    }
}
