using Test2.Models;
namespace Test2.Data
{
    public class Datainitializer
    {
        public static void SeedData(SchoolContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            if (dbContext.Students.Any())
            {
                return;
            }
            var students = new Student[]
            {
                new Student {StudentName = "Pham Huynh Duc", StudentClass="C2110I", StudentDob = new DateTime(2003,09,19), StudentId=1},
                new Student {StudentName = "Huan Hoa Hong", StudentClass="C2110H", StudentDob = new DateTime(1980,10,5), StudentId=2},
                new Student { StudentName = "Tien Bip", StudentClass = "C2110G", StudentDob = new DateTime(1975 , 04 , 20) , StudentId=3}
            };
            dbContext.Students.AddRange(students);
            dbContext.SaveChanges();

            if (dbContext.Subjects.Any())
            {
                return;
            }
            var subjects = new Subject[]
            {
                new Subject {SubjectId= 1, SubjectName="Math"},
                new Subject {SubjectId= 2, SubjectName="Vietnamese"},
                new Subject {SubjectId= 3, SubjectName="English"}
            };
            dbContext.Subjects.AddRange(subjects);
            dbContext.SaveChanges();

            if (dbContext.Exams.Any())
            {
                return;
            }
            var exams = new Exam[]
            {
                new Exam {ExamId=1,StudentId=1, SubjectId = 2, Mark = 50},
                new Exam {ExamId=2,StudentId=3, SubjectId = 2, Mark = 70},
                new Exam {ExamId=3,StudentId=2, SubjectId = 3, Mark = 100},
            };
            dbContext.Exams.AddRange(exams);
            dbContext.SaveChanges();
        }
    }
}
