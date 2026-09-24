using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Services;

public interface IEmployeeService
{
    List<Employee> GetEmployees();

Employee? UpdateEmployee(int id, Employee employee);

    Employee AddEmployee(Employee employee);

    bool DeleteEmployee(int id);
}