using DIPattarnDemo.Models;
using DIPattarnDemo.Repository;

namespace DIPattarnDemo.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student student)
        {
            return repo.AddStudent(student);
        }

        public int DeleteStudent(int id)
        {
             return repo.DeleteStudent(id); ;
        }

        public Student GetStudentById(int Id)
        {
            return repo.GetStudentById(Id); 
        }

        public Student GetStudentById(object id)
        {
            return repo.GetStudentById(id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return repo.GetStudents();
        }

        public int UpdateStudent(Student student)
        {
            return repo.UpdateStudent(student);
        }
    }
}
