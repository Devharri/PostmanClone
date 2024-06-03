namespace PostmanCloneLibrary;

public interface IApiAccess
{
    Task<string> CallApiAsync(string url, HttpAction action = HttpAction.GET);
    bool IsValidUrl(string url);
}