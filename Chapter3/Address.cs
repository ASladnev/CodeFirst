using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
  public class Address
  {
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
  }

  public class AddressMap : ComplexTypeConfiguration<Address>
  {
    public AddressMap ()
    {
      Property (a => a.Street)
        .HasMaxLength (40)
        .IsRequired ()
        .HasColumnName ("Street");
    }
  }

}
