using Exceptions.Interfaces;

namespace Exceptions.Classes;

public class GameDataParserApp<T> where T : Game {

    private string? _fileName;
    private List<T>? _games;
    private readonly IJsonHandler _jsonHandler;
    private readonly IFileHandler _fileHandler;

    public GameDataParserApp(IJsonHandler jsonHandler, IFileHandler fileHandler, List<T> games) {
        _jsonHandler = jsonHandler;
        _fileHandler = fileHandler;
        _games = games;
    }

    public void Run() {
        
        string fileContents = _fileHandler.FetchFile(out _fileName);
        _games = _jsonHandler.FetchListFromJsonString<T>(fileContents, _fileName);
        
        DisplayGameList(_games);
        
    }

    private static void DisplayGameList(List<T>? games) {
        if (games.Count > 0) {
            Console.WriteLine("---------------------");
            Console.WriteLine("Games in this file are:");
            foreach (IGameInformation game in games) {
                game.DisplayInformation();
            }
        }
        else {
            Console.WriteLine("No games in file.");
        }
    }
    
}