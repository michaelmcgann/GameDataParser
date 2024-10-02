using System.Text.Json;
using Exceptions.Interfaces;

namespace Exceptions.Classes.HelperClasses;

public class JsonHandler : IJsonHandler {

    private IDisplay _display;

    public JsonHandler(IDisplay display) {
        _display = display;
    }

    public List<T> FetchListFromJsonString<T>(string? fileContents, string? fileName) {
        List<T>? listResult;
        try {
            listResult = JsonSerializer.Deserialize<List<T>>(fileContents);
        }
        catch (JsonException e) {
            _display.DisplayMessage($"JSON in {fileName} file was not in a valid format.\n" +
                                    $"JSON body:\n" +
                                    $"{fileContents}");
            throw new JsonException($"{e.Message}. The file is: {fileName}", e);
        }

        return listResult;
    }
    
}