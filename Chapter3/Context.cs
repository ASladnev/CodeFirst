using System.Data.Entity;

namespace Chapter3
{
  public class Context : DbContext
  {
    public Context () : base ("name=chapter3")
    {
      

    }

    public DbSet<Person> Persons { get; set; }

    protected override void OnModelCreating (DbModelBuilder modelBuilder)
    {
      //base.OnModelCreating (modelBuilder);
      modelBuilder.Configurations.Add (new PersonMap ());

    }
  }
}
