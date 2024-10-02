namespace Exceptions.Interfaces;

public interface IFileHandler {

    string FetchFile(out string? filePath);

}