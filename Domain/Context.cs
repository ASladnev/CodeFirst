using System.Data.Entity;

namespace Domain
{
  public class Context : DbContext 
  {
    public Context () : base ("name=chapter7")
    {
    }

    public DbSet<Person> Person { get; set; }
    public DbSet<Company> Company { get; set; }

    protected override void OnModelCreating (DbModelBuilder modelBuilder)
    {
      modelBuilder.Configurations.Add (new PersonMap ());
    }
  }
}
