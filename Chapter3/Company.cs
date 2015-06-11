using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
  public class Company
  {

    public Company ()
    {
      Persons = new HashSet<Person> ();
      Address = new Address ();
    }

    public int CompanyId { get; set; }
    public string CompanyName { get; set; }
    public ICollection<Person> Persons { get; set; }
    public Address Address { get; set; }

  }
}
