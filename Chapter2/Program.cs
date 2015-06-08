using System.Data.Entity;
using System.Linq;

namespace Chapter2
{
  class Program
  {
    static void Main (string[] args)
    {
      Database.SetInitializer (new Initializer ());


      using (var context = new Context ())
      {
        context.People.ToList ();

        //        var person = new Person {FirstName = "John", LastName = "Doe"};
        //        context.People.Add (person);
        //        context.SaveChanges ();
      }
    }
  }
}
