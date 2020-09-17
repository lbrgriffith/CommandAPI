using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Models
{
    /// <summary>
    /// This means that we can choose which classes, (model classes), 
    /// we want to put under DBContext control and hence represent 
    /// in the DB.
    /// </summary>
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options) : base(options)
        { }
        public DbSet<Command> CommandItems { get; set; }
    }
}
