using EmployeeManagement.API.Data;
using EmployeeManagement.API.Models;

namespace EmployeeManagement.API.Services;

public class EmployeeService : IEmployeeService
{
    private readonly EmployeeDbContext _context;

    public EmployeeService(EmployeeDbContext context)
    {
        _context = context;
    }

    public List<Employee> GetEmployees()
    {
        return _context.Employees.ToList();
    }

    public Employee AddEmployee(Employee employee)
{
    _context.Employees.Add(employee);

    _context.SaveChanges();

    return employee;
}

public Employee? UpdateEmployee(int id, Employee employee)
{
    var existingEmployee = _context.Employees.Find(id);

    if (existingEmployee == null)
    {
        return null;
    }

    existingEmployee.Name = employee.Name;
    existingEmployee.Email = employee.Email;
    existingEmployee.Phone = employee.Phone;
    existingEmployee.Department = employee.Department;
    existingEmployee.Salary = employee.Salary;
    existingEmployee.JoiningDate = employee.JoiningDate;

    _context.SaveChanges();

    return existingEmployee;
}

public bool DeleteEmployee(int id)
{
    var employee = _context.Employees.Find(id);

    if (employee == null)
    {
        return false;
    }

    _context.Employees.Remove(employee);

    _context.SaveChanges();

    return true;
}
}