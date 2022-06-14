namespace Hibob.Dotnet.Core.Model;

public class PersonalDetails
{
    public string? ShortBirthDate { get; set; }
    public string? Pronouns { get; set; }
    public CommunicationInfo? Communication { get; set; }
    public object? Custom { get; set; }
    public string? Honorific { get; set; }
    public string[]? Nationality { get; set; }
}
