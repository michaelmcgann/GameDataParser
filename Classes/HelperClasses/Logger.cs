namespace Exceptions.Classes.HelperClasses;

public class Logger {

    private readonly string _logFileName;

    public Logger(string logFileName) {
        _logFileName = logFileName;
    }

    public void Log(Exception ex) {
        string entry = $"{DateTime.Now}\n" +
                       $"Exception Message: {ex.Message}\n" +
                       $"Stack Trace: {ex.StackTrace}\n" +
                       $"\n";
        File.AppendAllText(_logFileName, entry);
    }

}