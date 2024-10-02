using Exceptions.Classes;
using Exceptions.Classes.HelperClasses;
using Exceptions.Interfaces;

namespace Exceptions;

class Program {
    
    static void Main(string[] args) {
        IFileHandler fileHandler = new FileHandler();
        List<VideoGame> games = new List<VideoGame>();
        IDisplay display = new ConsoleDisplay();
        IJsonHandler jsonHandler = new JsonHandler(display);
        GameDataParserApp<VideoGame> app = new(jsonHandler, fileHandler, games, display);
        
        Logger logger = new("log.txt");
        
        try {
            app.Run();
        }
        catch (Exception e) {
            display.DisplayMessage("Sorry, the app has experienced some unexpected error. Please restart.");
            logger.Log(e);
        }

    }
    
    
}



