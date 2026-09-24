using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Services;

public interface IEmployeeService
{
    List<Employee> GetEmployees();
}