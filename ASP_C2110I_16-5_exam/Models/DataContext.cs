using Microsoft.EntityFrameworkCore;

namespace ASP_C2110I_16_5_exam.Models
{
    public class DataContext:DbContext
    {
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ProjectEmployee> ProjectEmployees { get; set; }

        public DataContext()
        {

        }
    }
}
