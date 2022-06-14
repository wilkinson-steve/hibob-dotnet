namespace Hibob.Dotnet.Core.Model;

public class PayrollDetails
{
    public object? AdditionalPensionContribution { get; set; }
    public object? Nin { get; set; }
    public Duration? TimeSinceLastSalaryChange { get; set; }
    public SalaryInfo? Salary { get; set; }
    public object? TaxCode { get; set; }
    public Employment? Employment { get; set; }
    public VariableRemuneration? Variable { get; set; }
}
