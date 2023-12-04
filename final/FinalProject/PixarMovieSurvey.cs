using System;

public class PixarMovieSurvey : MovieSurvey{

    private List<string> pixarMovies;

    public PixarMovieSurvey()
    {
        pixarMovies = new List<string>();
    }

    public List<string> GetPixarMovies(){
        pixarMovies.Add("Toy Story");
        pixarMovies.Add("A Bug's Life");
        pixarMovies.Add("Toy Story 2");
        pixarMovies.Add("Monsters, Inc.");
        pixarMovies.Add("Finding Nemo");
        pixarMovies.Add("The Incredibles");
        pixarMovies.Add("Cars");
        pixarMovies.Add("Ratatouille");
        pixarMovies.Add("WALL-E");
        pixarMovies.Add("Up");
        pixarMovies.Add("Toy Story 3");
        pixarMovies.Add("Cars 2");
        pixarMovies.Add("Brave");
        pixarMovies.Add("Monsters University");
        pixarMovies.Add("Inside Out");
        pixarMovies.Add("The Good Dinosaur");
        pixarMovies.Add("Finding Dory");
        pixarMovies.Add("Cars 3");
        pixarMovies.Add("Coco");
        pixarMovies.Add("Incredibles 2");
        pixarMovies.Add("Toy Story 4");
        pixarMovies.Add("Onward");
        pixarMovies.Add("Soul");
        pixarMovies.Add("Luca");
        pixarMovies.Add("Turning Red");
        pixarMovies.Add("Lightyear");
        pixarMovies.Add("Elemental");
        return new List<String>(pixarMovies);
    }
    
    public override string GetFavorite(){
        return $"{favorite}";
    }
    public override string GetLeastFavorite()
    {
        return $"{leastFavorite}";
    }

    public void AddPixarMovieResponses(string locationWatched, int weeklyHoursWatched, string genrePreference)
    {
        // Use the provided responses or perform additional processing
        SetLocationWatched(locationWatched);
        SetWeeklyHoursWatched(weeklyHoursWatched);
        SetGenrePreference(genrePreference);
        Console.WriteLine($"{locationWatched}{weeklyHoursWatched}{genrePreference}");

        // Add Pixar-specific responses or perform additional processing
    }
}