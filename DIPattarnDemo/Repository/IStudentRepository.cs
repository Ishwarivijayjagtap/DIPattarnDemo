using DIPattarnDemo.Models;

namespace DIPattarnDemo.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int Id);
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
        Student GetStudentById(object id);
    }
}
