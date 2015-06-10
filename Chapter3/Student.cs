using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
  public class Student
  {
    public int PersonId { get; set; }
    public virtual Person Person { get; set; }
    public string CollegeName { get; set; }
    public DateTime EnrollmentDate { get; set; }
  }

  public class StudentMap : EntityTypeConfiguration<Student>
  {
    public StudentMap()
    {
      HasRequired(s => s.Person).WithOptional (p =>p.Student);
      HasKey(s =>s.PersonId);
      Property(s =>s.CollegeName).HasMaxLength(50).IsRequired();
    }
  }
}
