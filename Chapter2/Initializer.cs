using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
  public class Initializer : DropCreateDatabaseIfModelChanges<Context>
  {
    protected override void Seed (Context context)
    {
      context.Companies.Add (new Company {CompantyName = "Microsoft"});
      context.Companies.Add (new Company {CompantyName = "Oracle"});
      base.Seed (context);
    }
  }
}
