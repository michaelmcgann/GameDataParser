using Exceptions.Interfaces;

namespace Exceptions.Classes.HelperClasses;

public class Display : IDisplay {

    public void DisplayMessage(string message) {
        Console.WriteLine(message);
    }
    
}