using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly EmployeeContext _context;

    public EmployeesController(EmployeeContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> CreateEmployee(Employee employee)
    {
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
        return Ok(employee);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateEmployee(int id, Employee employee)
    {
        var existingEmployee = await _context.Employees.FindAsync(id);
        if (existingEmployee == null)
        {
            return NotFound();
        }

        existingEmployee.Name = employee.Name;
        existingEmployee.Email = employee.Email;
        existingEmployee.CPF = employee.CPF;
        existingEmployee.PhoneNumber = employee.PhoneNumber;
        existingEmployee.DateOfBirth = employee.DateOfBirth;
        existingEmployee.EmploymentType = employee.EmploymentType;
        existingEmployee.Status = employee.Status;

        await _context.SaveChangesAsync();
        return Ok(existingEmployee);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        var employee = await _context.Employees.FindAsync(id);
        if (employee == null)
        {
            return NotFound();
        }

        _context.Employees.Remove(employee);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetEmployees([FromQuery] string name = null)
    {
        var employees = string.IsNullOrEmpty(name)
            ? await _context.Employees.ToListAsync()
            : await _context.Employees.Where(e => e.Name.Contains(name)).ToListAsync();

        return Ok(employees);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployeeById(int id)
    {
        var employee = await _context.Employees.FindAsync(id);
        
        if (employee == null)
        {
            return NotFound();
        }

        return Ok(employee);
    }
}
