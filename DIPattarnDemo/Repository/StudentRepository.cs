using DIPattarnDemo.Data;
using DIPattarnDemo.Models;

namespace DIPattarnDemo.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;   
        }
        public int AddStudent(Student student)
        {
            int result = 0;
            db.Students?.Add(student);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int result = 0;
            var stud = db.Students?.Where(x => x.Rollno == id).SingleOrDefault();
            if (stud != null)
            {
                db.Students?.Remove(stud);
                result = db.SaveChanges();
            }
            return result;
        }

        public Student GetStudentById(int Id)
        {
            return db.Students?.Where(x => x.Rollno == Id).SingleOrDefault();
        }

        public Student GetStudentById(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            return db.Students.ToList(); 
        }

        public int UpdateStudent(Student student)
        {
            int result = 0;
            var stud = db.Students?.Where(x => x.Rollno == student.Rollno).SingleOrDefault();
            if (stud != null)
            {
                stud.Name = student.Name;
                stud.Percentage = student.Percentage;
                stud.Branch = student.Branch;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
