using Microsoft.EntityFrameworkCore;

namespace ExampleFluentAPI
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new StudentEntityConfiguration());


            //Configure default schema
            //modelBuilder.HasDefaultSchema("Admin");

            ////Map entity to table
            //modelBuilder.Entity<Student>().ToTable("StudentInfo");
            //modelBuilder.Entity<Standard>().ToTable("StandardInfo", "dbo");

            //modelBuilder.Entity<Student>().HasKey(y=>y.StudentID);
            //modelBuilder.Entity<Standard>().HasKey(s => s.StandardId);

            //modelBuilder.Entity<Student>()
            //      .Property(p => p.StudentName)
            //      .HasColumnName("name")
            //      .HasColumnOrder(3)
            //      .HasColumnType("nvarchar")
            //      .IsRequired()
            //      .HasMaxLength(233)
            //      .IsFixedLength()
            //      ;    


        }
    }
}
