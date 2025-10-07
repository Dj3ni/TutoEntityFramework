namespace TutoEntityFramework.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }

		//Many to many avec Student
		public ICollection<Student> Students { get; set; }
	}
}
