using Exceptions.Interfaces;

namespace Exceptions.Classes.HelperClasses;

public class ConsoleDisplay : IDisplay {

    public void DisplayMessage(string message) {
        Console.WriteLine(message);
    }
    
}