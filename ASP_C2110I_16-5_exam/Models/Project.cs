namespace ASP_C2110I_16_5_exam.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public virtual ICollection<ProjectEmployee> ProjectEmployees{ get; set; }

        public Project()
        {
            this.ProjectEmployees = new HashSet<ProjectEmployee>();
        }


    }
}
