using System.Net;

namespace PostmanCloneLibrary;

public class ApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url, HttpAction action = HttpAction.GET) 
    {
        var response = await client.GetAsync(url);

        if (response.StatusCode == HttpStatusCode.OK)
        {
            string json = await response.Content.ReadAsStringAsync();

            return json;
        }
        else
        {
            return $"Error:  {response.StatusCode}";
        }
    }

    public bool IsValidUrl(string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return false;
        }
        else if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) && (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}