﻿using Exceptions.Classes;
using Exceptions.Classes.HelperClasses;
using Exceptions.Interfaces;

namespace Exceptions;

class Program {
    
    static void Main(string[] args) {

        IJsonHandler jsonHandler = new JsonHandler();
        IFileHandler fileHandler = new FileHandler();
        List<VideoGame> games = new List<VideoGame>();
        GameDataParserApp<VideoGame> app = new(jsonHandler, fileHandler, games);
        
        Logger logger = new("log.txt");
        
        try {
            app.Run();
        }
        catch (Exception e) {
            Console.WriteLine("Sorry, the app has experienced some unexpected error. Please restart.");
            logger.Log(e);
        }

    }
    
    
}



