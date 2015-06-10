using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace Chapter3
{
  public  class Person
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

    public int? PersonTypeId { get; set; }
    public virtual PersonType PersonType { get; set; }
    public virtual ICollection<Phone> Phones { get; set; }

    public virtual ICollection<Company> Companies { get; set; }

    public virtual Student Student { get; set; }
    public Person ()
    {
      Phones = new HashSet<Phone> ();
    }


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
