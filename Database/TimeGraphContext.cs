using Microsoft.EntityFrameworkCore;
public class TimeGraphContext : DbContext
{
  public TimeGraphContext(DbContextOptions<TimeGraphContext> options) : base(options)
  {
  }

  public DbSet<Project> Projects { get; set; }
  public DbSet<TimeLog> TimeLogs { get; set; }
}