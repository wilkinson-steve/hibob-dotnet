namespace Hibob.Dotnet.Core.Model;

public class WorkDetails
{
    public string? ShortStartDate { get; set; }
    public string? StartDate { get; set; }
    public string? Manager { get; set; }
    public object? WorkPhone { get; set; }
    public Duration? TenureDuration { get; set; }
    public object? custom { get; set; }
    public Duration? DurationOfEmployment { get; set; }
    public int? ReportsToIdInCompany { get; set; }
    public int? EmployeeIdInCompany { get; set; }
    public ReportingLineInfo? ReportsTo { get; set; }
    public object? WorkMobile { get; set; }
    public object? IndirectReports { get; set; }
    public string? Department { get; set; }
    public int? SiteId { get; set; }
    public int? TenureYears { get; set; }
    public bool? IsManager { get; set; }
    public string? Title { get; set; }
    public string? Site { get; set; }
    public string? ActiveEffectiveDate { get; set; }
    public object? DirectReports { get; set; }
    public string? SecondLevelManager { get; set; }
    public int? DaysOfPreviousService { get; set; }
    public decimal? YearsOfService { get; set; }
}
