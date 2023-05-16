namespace ASP_C2110I_16_5_exam.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public System.DateTime EmployeeDOB { get; set; }
        public ICollection<ProjectEmployee> ProjectEmployees{ get; set; }

        public Employee()
        {
            this.ProjectEmployees = new HashSet<ProjectEmployee>();
        }
    }
}
