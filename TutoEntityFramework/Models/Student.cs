using System.ComponentModel.DataAnnotations;

namespace TutoEntityFramework.Models
{
	public class Student
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		[MinLength(2)]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(100)]
		[MinLength(2)]
		public string LastName { get; set; }

		//Many to many avec Course
		public ICollection<Course> Courses { get; set; }
	}
}
