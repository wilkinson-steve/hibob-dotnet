using Hibob.Dotnet.Core.Model;
using RestSharp;
using RestSharp.Authenticators;

namespace Hibob.Dotnet.Core;

public class HibobConnection
{
    private const string _baseUri = "https://api.hibob.com/v1";

    private RestClient _client;

    public HibobConnection(string username, string apiKey)
    {
        _client = new RestClient(_baseUri);

        _client.Authenticator = new HttpBasicAuthenticator(username, apiKey);

        //_client.UseSerializer(() => new HibobJsonSerializer());
    }

    public async Task<List<Employee>?> GetEmployeesAsync()
    {
        var request = new RestRequest("people");

        var employeeModel =  await _client.GetAsync<EmployeesModel>(request);

        return employeeModel?.Employees;
    }
}
