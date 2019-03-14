using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
	public class Student
	{
		public int ID { get; set; }
		[Required]
		[StringLength(50)]
		[Display(Name = "Last name")]
		public string LastName { get; set; }
		[Required]
		[StringLength(25, ErrorMessage = "First name cannot be longer than 25 characters.")]
		[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "First name must start with a capital letter!")]
		[Column("FirstName")]
		[Display(Name = "First name")]
		public string FirstMidName { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		public DateTime EnrollmentDate { get; set; }
		[Display(Name = "Full name")]
		public string FullName
		{
			get
			{
				return LastName + ", " + FirstMidName;
			}
		}

		public ICollection<Enrollment> Enrollments { get; set; }
	}
}
