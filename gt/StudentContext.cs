using gt;
using System.Data.Entity;

public class StudentContext : DbContext
{
    public StudentContext() : base("name=StudentDBConnectionString")
    {
    }

    public DbSet<Student> Students { get; set; }
}
