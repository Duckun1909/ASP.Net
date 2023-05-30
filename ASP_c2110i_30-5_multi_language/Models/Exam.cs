using System;
using System.Collections.Generic;

namespace Test2.Models
{
    public partial class Exam
    {
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public int? Mark { get; set; }

        public virtual Student Student { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
