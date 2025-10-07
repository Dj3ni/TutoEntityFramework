using Microsoft.EntityFrameworkCore;

namespace TutoEntityFramework.Models
{
	public class EFContext : DbContext
	{
		public EFContext(DbContextOptions<EFContext> options) : base(options)
		{
		}
		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>()
				.HasMany(s => s.Courses)
				.WithMany(c => c.Students)
				.UsingEntity(j => j.ToTable("StudentCourse")); //Nom de la table de jonction
			base.OnModelCreating(modelBuilder);
		}
	}	

}


