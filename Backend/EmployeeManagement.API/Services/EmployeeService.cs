using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Services;

public class EmployeeService : IEmployeeService
{
    public List<Employee> GetEmployees()
    {
        return new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Email = "john@example.com",
                Phone = "9876543210",
                Department = "IT",
                Salary = 50000,
                JoiningDate = new DateTime(2024, 1, 15)
            },
            new Employee
            {
                Id = 2,
                Name = "Priya",
                Email = "priya@example.com",
                Phone = "9876543211",
                Department = "HR",
                Salary = 45000,
                JoiningDate = new DateTime(2023, 8, 10)
            }
        };
    }
}