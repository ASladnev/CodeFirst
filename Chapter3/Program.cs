using System.Data.Entity;
using System.Linq;

namespace Chapter3
{
  class Program
  {
    static void Main (string[] args)
    {
      Database.SetInitializer (new Initializer ());

      using (var context = new Context ())
      {
        //var person = context.Persons.ToList ();
        var person = new Person {FirstName = "John", LastName = "Doe", IsActive = true};
        person.Phones.Add (new Phone {PhoneNumber = "11111111111111"});
        person.Phones.Add (new Phone { PhoneNumber = "22222222222222" });
        person.Phones.Add (new Phone { PhoneNumber = "33333333333333" });

        context.Persons.Add (person);
        context.SaveChanges ();
      }


    }
  }
}
