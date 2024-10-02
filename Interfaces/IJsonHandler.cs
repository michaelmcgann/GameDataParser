namespace Exceptions.Interfaces;

public interface IJsonHandler {

    List<T> FetchListFromJsonString<T>(string? fileContents, string? fileName);

}