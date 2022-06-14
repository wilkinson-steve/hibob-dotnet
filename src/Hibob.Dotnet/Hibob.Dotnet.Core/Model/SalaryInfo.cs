namespace Hibob.Dotnet.Core.Model;

public class SalaryInfo
{
    public Payment? MonthlyPayment { get; set; }
    public string? PayPeriod { get; set; }
    public Payment? YearlyPayment { get; set; }
    public Payment? Payment { get; set; }
    public string? ActiveEffectiveDate { get; set; }
    public string? PayFrequency { get; set; }
}
