namespace Exceptions.Interfaces;

public abstract class Game : IGameInformation {
    
    public string Title { get; init; }
    public int ReleaseYear { get; init; }
    public decimal Rating { get; init; }
    
    public Game(string title, int releaseYear, decimal rating) {
        Title = title;
        ReleaseYear = releaseYear;
        Rating = rating;
    }

    public abstract string RetrieveInformation();

}