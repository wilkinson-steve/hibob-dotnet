namespace Hibob.Dotnet.Core.Model;

public class Employee
{
    public string? FullName { get; set; }
    public string? DisplayName { get; set; }
    public PayrollDetails? Payroll { get; set; }
    public Address? Address { get; set; }
    public PersonalDetails? Personal { get; set; }
    public DateTime? CreationDateTime { get; set; }
    public WorkDetails? Work { get; set; }
    public InternalInfo? Internal { get; set; }
    public object? SecondName { get; set; }
    public object? WorkContact { get; set; }
    public string? AvatarUrl { get; set; }
    public AboutInfo? About { get; set; }
    public int? CompanyId { get; set; }
    public string? Email { get; set; }
    public string? Surname { get; set; }
    public object? Identification { get; set; }
    public HomeDetails? Home { get; set; }
    public PersonalFinancialInfo? Financial { get; set; }
    public string? FirstName { get; set; }
    public string? Id { get; set; }

}
