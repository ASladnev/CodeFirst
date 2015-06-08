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
        var person = context.Persons.ToList ();
      }

    }
  }
}
