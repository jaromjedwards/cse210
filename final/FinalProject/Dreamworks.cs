using System;

public class DreamworksMovieSurvey : MovieSurvey{

    private List<string> dreamworksMovies;

    public DreamworksMovieSurvey()
    {
        dreamworksMovies = new List<string>();
    }

    public List<string> GetDreamworksMovies(){
    dreamworksMovies.Add("Shrek");
    dreamworksMovies.Add("How to Train Your Dragon");
    dreamworksMovies.Add("Kung Fu Panda");
    dreamworksMovies.Add("Madagascar");
    dreamworksMovies.Add("The Prince of Egypt");
    dreamworksMovies.Add("Spirit: Stallion of the Cimarron");
    dreamworksMovies.Add("Shrek 2");
    dreamworksMovies.Add("Shrek the Third");
    dreamworksMovies.Add("Shrek Forever After");
    dreamworksMovies.Add("Monsters vs. Aliens");
    dreamworksMovies.Add("Megamind");
    dreamworksMovies.Add("Kung Fu Panda 2");
    dreamworksMovies.Add("Puss in Boots");
    dreamworksMovies.Add("Madagascar 3: Europe's Most Wanted");
    dreamworksMovies.Add("Rise of the Guardians");
    dreamworksMovies.Add("The Croods");
    dreamworksMovies.Add("Turbo");
    dreamworksMovies.Add("Mr. Peabody & Sherman");
    dreamworksMovies.Add("How to Train Your Dragon 2");
    dreamworksMovies.Add("Penguins of Madagascar");
    dreamworksMovies.Add("Kung Fu Panda 3");
    dreamworksMovies.Add("Trolls");
    dreamworksMovies.Add("The Boss Baby");
    dreamworksMovies.Add("Captain Underpants: The First Epic Movie");
    dreamworksMovies.Add("How to Train Your Dragon: The Hidden World");
    dreamworksMovies.Add("Abominable");
    dreamworksMovies.Add("The Croods: A New Age");
    dreamworksMovies.Add("Spirit Untamed");
    dreamworksMovies.Add("Trolls World Tour");
    dreamworksMovies.Add("The Boss Baby: Family Business");
    dreamworksMovies.Add("The Bad Guys");
    dreamworksMovies.Add("Puss in Boots: The Last Wish");
    dreamworksMovies.Add("Ruby Gillman, Teenage Kraken");
    dreamworksMovies.Add("Trolls Band Together");
    
        return new List<String>(dreamworksMovies);
    }
    
    public override string GetFavorite(){
        return $"{favorite}";
    }
    public override string GetLeastFavorite()
    {
        return $"{leastFavorite}";
    }

    public void AddDreamworksMovieResponses(string locationWatched, int weeklyHoursWatched, string genrePreference)
    {
        // Use the provided responses or perform additional processing
        SetLocationWatched(locationWatched);
        SetWeeklyHoursWatched(weeklyHoursWatched);
        SetGenrePreference(genrePreference);
        Console.WriteLine($"{locationWatched}{weeklyHoursWatched}{genrePreference}");

        // Add Dreamworks-specific responses or perform additional processing
    }
}