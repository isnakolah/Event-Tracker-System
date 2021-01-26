using Microsoft.EntityFrameworkCore;

namespace poneaChallenge.Models
{
    public class TaskIssuedContext : DbContext
    {
        public TaskIssuedContext(DbContextOptions<TaskIssuedContext> options) : base(options)
        {
        }

        public DbSet<TaskIssued> TasksIssued { get; set; }
        public DbSet<Messages> Messages { get; set; }
    }
}