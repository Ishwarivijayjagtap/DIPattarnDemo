using DIPattarnDemo.Models;

namespace DIPattarnDemo.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int Id);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int id);
        Employee GetEmployeeById(object id);
    }

}