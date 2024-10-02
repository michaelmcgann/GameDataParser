using Exceptions.Interfaces;

namespace Exceptions.Classes.HelperClasses;

public class LocalFileHandler : IFileHandler {

    public string FetchFile(out string? filePath) {
        string fileContents = "";
        bool isFileRead = false;
        do {
            
            Console.WriteLine("Enter the name of the file you want to read: ");
            filePath = Console.ReadLine();
            
            if (filePath is null) {
                Console.WriteLine("The file name cannot be null");
            } else if (filePath == string.Empty) {
                Console.WriteLine("The file name cannot be empty.");
            } else if (!File.Exists(filePath)) {
                Console.WriteLine("The file does not exist."); 
            }
            else {
                fileContents = File.ReadAllText(filePath);
                isFileRead = true;
            }
        } while (!isFileRead);

        return fileContents;
    }
    
}