using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB;

public class Student: Person
{
    [Display(Name = "Enrollment Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime EnrollmentDate { get; set; }

    public ICollection<Enrollment>? Enrollments { get; set; }

}
