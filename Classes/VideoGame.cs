using Exceptions.Interfaces;

namespace Exceptions.Classes;

public class VideoGame : Game {
    
    public VideoGame(string title, int releaseYear, decimal rating) : 
    base(title, releaseYear, rating) {
    }

    public override string RetrieveInformation() {
        return $"-------------------\n" +
               $"Title: {Title}\n" +
               $"Release year: {ReleaseYear}\n" +
               $"Rating: {Rating}\n" +
               $"-------------------";
    }
}