using EmployeeManagement.API.Models;
using EmployeeManagement.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult GetEmployees()
    {
        var employees = _employeeService.GetEmployees();

        return Ok(employees);
    }

    [HttpPost]
public IActionResult AddEmployee(Employee employee)
{
    var addedEmployee = _employeeService.AddEmployee(employee);

    return Ok(addedEmployee);
}

[HttpPut("{id}")]
public IActionResult UpdateEmployee(int id, Employee employee)
{
    var updatedEmployee = _employeeService.UpdateEmployee(id, employee);

    if (updatedEmployee == null)
    {
        return NotFound();
    }

    return Ok(updatedEmployee);
}

[HttpDelete("{id}")]
public IActionResult DeleteEmployee(int id)
{
    var deleted = _employeeService.DeleteEmployee(id);

    if (!deleted)
    {
        return NotFound();
    }

    return Ok("Employee deleted successfully");
}
}