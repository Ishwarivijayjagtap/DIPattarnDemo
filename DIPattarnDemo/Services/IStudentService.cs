using DIPattarnDemo.Models;

namespace DIPattarnDemo.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int Id);
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
        Student GetStudentById(object id);
    }
}
