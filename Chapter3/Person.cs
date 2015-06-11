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
    public byte[] FamilyPicture { get; set; }
    public bool IsActive { get; set; }
    public int NumberOfCars { get; set; }
    public PersonState PersonState { get; set; }

    public string FullName
    {
      get { return FirstName + " " + LastName; }
      set { FirstName = value; }
    }


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

  public enum PersonState
  {
    Active,
    Inactive,
    Unknown,
  }

 
  public class PersonMap : EntityTypeConfiguration<Person>
  {
    public PersonMap ()
    {
      Map (p =>
      {
        p.Properties (ph => new {ph.Photo, ph.FamilyPicture});
        p.ToTable ("PersonBlob");
      });

      Map (p =>
      {
        p.Properties (ph=> new
        {
          ph.BirthDate, ph.FirstName, ph.HeightInFeet, ph.IsActive, ph.LastName, ph.MiddleName, ph.NumberOfCars, ph.PersonState, ph.PersonTypeId
        });
        p.ToTable ("Person");
      });


      Property (p => p.FirstName).HasMaxLength (30).IsRequired ();
      Property (p => p.LastName).HasMaxLength (30);
      Property (p => p.MiddleName).HasMaxLength (1).IsFixedLength ().IsUnicode (false);
      Property (p => p.HeightInFeet).HasPrecision (4, 2);
      Property (p => p.Photo).IsVariableLength ().HasMaxLength (4000);
      Ignore (p => p.FullName);
    }
  }

}
