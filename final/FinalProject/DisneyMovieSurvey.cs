using System;

public class DisneyMovieSurvey : MovieSurvey{

    private List<string> disneyMovies;

    public DisneyMovieSurvey()
    {
        disneyMovies = new List<string>();
    }

    public List<string> GetDisneyMovies(){
        disneyMovies.Add("Snow White and the Seven Dwarfs");
        disneyMovies.Add("Cinderella");
        disneyMovies.Add("Sleeping Beauty");
        disneyMovies.Add("The Little Mermaid");
        disneyMovies.Add("Beauty and the Beast");
        disneyMovies.Add("Aladdin");
        disneyMovies.Add("Pocahontas");
        disneyMovies.Add("Mulan");
        disneyMovies.Add("The Princess and the Frog");
        disneyMovies.Add("Tangled");
        disneyMovies.Add("Brave");
        disneyMovies.Add("Frozen");
        disneyMovies.Add("Moana");
        disneyMovies.Add("Encanto");

        return new List<String>(disneyMovies);
    }
    
    public override string GetFavorite(){
        return $"{favorite}";
    }
    public override string GetLeastFavorite()
    {
        return $"{leastFavorite}";
    }

    public void AddDisneyMovieResponses(string locationWatched, int weeklyHoursWatched, string genrePreference)
    {
        // Use the provided responses or perform additional processing
        SetLocationWatched(locationWatched);
        SetWeeklyHoursWatched(weeklyHoursWatched);
        SetGenrePreference(genrePreference);
        Console.WriteLine($"{locationWatched}{weeklyHoursWatched}{genrePreference}");

        // Add Disney-specific responses or perform additional processing
    }
}