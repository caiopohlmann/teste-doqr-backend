using System;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string EmploymentType { get; set; }
    public bool Status { get; set; }
}
