using Exceptions.Interfaces;

namespace Exceptions.Classes;

public class GameDataParserApp<T> where T : Game {

    private string? _fileName;
    private List<T>? _games;
    private readonly IJsonHandler _jsonHandler;
    private readonly IFileHandler _fileHandler;
    private readonly IDisplay _display;

    public GameDataParserApp(IJsonHandler jsonHandler, IFileHandler fileHandler, List<T> games, IDisplay display) {
        _jsonHandler = jsonHandler;
        _fileHandler = fileHandler;
        _games = games;
        _display = display;
    }

    public void Run() {
        
        string fileContents = _fileHandler.FetchFile(out _fileName);
        _games = _jsonHandler.FetchListFromJsonString<T>(fileContents, _fileName);
        
        DisplayGameList();
    }

    private void DisplayGameList() {
        if (_games.Count > 0) {
            _display.DisplayMessage("---------------------");
            _display.DisplayMessage("Games in this file are:");
            foreach (T game in _games) {
                _display.DisplayMessage(game.RetrieveInformation());
            }
        }
        else {
            _display.DisplayMessage("No games in file.");
        }
    }
    
}