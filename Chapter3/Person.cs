using System;
using System.Data.Entity.ModelConfiguration;

namespace Chapter3
{
  public class Person
  {
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime? BirthDate { get; set;}
    public decimal HeightInFeet { get; set; }
    public byte[] Photo { get; set; }
    public bool IsActive { get; set; }
    public int NumberOfCars { get; set; }
  }

  public class PersonMap : EntityTypeConfiguration<Person>
  {
    public PersonMap ()
    {
      Property (p => p.FirstName).HasMaxLength (30).IsRequired ();
      Property (p => p.LastName).HasMaxLength (30);
      Property (p => p.MiddleName).HasMaxLength (1).IsFixedLength ().IsUnicode (false);
      Property (p => p.HeightInFeet).HasPrecision (4, 2);
      Property (p => p.Photo).IsVariableLength ().HasMaxLength (4000);
    }
  }

}
