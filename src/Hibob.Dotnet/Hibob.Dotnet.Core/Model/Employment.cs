namespace Hibob.Dotnet.Core.Model;

public class Employment
{
    public decimal? Fte { get; set; }
    public string? Type { get; set; }
    public object? FlsaCode { get; set; }
    public string? Contract { get; set; }
    public int? CalendarId { get; set; }
    public string? SalaryPayType { get; set; }
    public object? WorkingPattern { get; set; }
    public string? ActiveEffectiveDate { get; set; }
    public decimal? WeeklyHours { get; set; }
    public SiteWorkingPattern? siteWorkingPattern { get; set; }
}
