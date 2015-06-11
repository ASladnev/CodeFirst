using System.Data.Entity.ModelConfiguration;

namespace Domain
{
  public class Person
  {
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
  }

  public class PersonMap : EntityTypeConfiguration<Person>
  {
    public PersonMap ()
    {
      Property (p => p.FirstName).HasMaxLength (40).IsRequired ();
      Property (p => p.LastName).HasMaxLength (20).IsRequired ();
    }
  }

}
