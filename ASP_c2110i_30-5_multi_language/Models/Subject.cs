using System;
using System.Collections.Generic;

namespace Test2.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Exams = new HashSet<Exam>();
        }

        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
