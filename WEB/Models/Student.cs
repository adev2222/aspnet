using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB;

public class Student
{
    public int Id { get; set; }
    [Required]
    [StringLength(50, MinimumLength=2)]
    [Column("FirstName")]
    public string FirstMidName { get; set; }
    [StringLength(50, MinimumLength=2)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    [Display(Name = "Enrollment Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime EnrollmentDate { get; set; }

    [Display(Name = "Full Name")]
    public string FullName
    {
        get
        {
            return LastName + ", " + FirstMidName;
        }
    }

    public ICollection<Enrollment>? Enrollments { get; set; }

}
