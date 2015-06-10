using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace Chapter3
{
  public class PersonType
  {
    public int PersonTypeId { get; set; }
    public string TypeName { get; set; }
    public virtual ICollection<Person> Persons { get; set; }
  }

  public class PersonTypeMap : EntityTypeConfiguration<PersonType>
  {
    public PersonTypeMap ()
    {
      HasMany (p => p.Persons)
        .WithOptional(p=>p.PersonType)
        .HasForeignKey (p=>p.PersonTypeId)
        .WillCascadeOnDelete(false);
    }
  }

}
