using System.Globalization;
using System.Net;
using System.Net.Http.Json;
using Exizent.CaseManagement.Client.Models;

namespace Exizent.CaseManagement.Client;

public class CaseManagementApiClient : ICaseManagementApiClient
{
    private readonly HttpClient _client;

    public CaseManagementApiClient(HttpClient httpClient)
    {
        _client = httpClient;
    }

    public async Task<CaseResourceRepresentation?> GetCase(Guid caseId, int? companyId = null)
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, $"/cases/{caseId}");
        if (companyId.HasValue)
        {
            request.Headers.Add("Company-Id", companyId.Value.ToString(CultureInfo.InvariantCulture));
        }

        using var response = await _client.SendAsync(request);

        if (response.StatusCode == HttpStatusCode.NotFound)
        {
            return null;
        }

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CaseResourceRepresentation>(DefaultJsonSerializerOptions
            .Instance);
    }
}