namespace ASP_C2110I_16_5_exam.Models
{
    public class ProjectEmployee
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public string Tasks { get; set; }
        public Employee Employees { get; set; }
        public Project Projects { get; set; }
    }
}
