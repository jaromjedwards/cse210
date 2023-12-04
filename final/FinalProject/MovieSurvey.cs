using System;

public abstract class MovieSurvey{

    private string LocationWatched;
    private int weeklyHoursWatched;
    private string genrePreference;
    protected string favorite;
    protected string leastFavorite;

    public string GetLocationWatched(){
        return LocationWatched;
    }
    public void SetLocationWatched(string LocationWatched){
        this.LocationWatched = LocationWatched;
    }
    public int GetWeeklyHoursWatched(){
    return weeklyHoursWatched;
    }

    public void SetWeeklyHoursWatched(int weeklyHoursWatched){
        this.weeklyHoursWatched = weeklyHoursWatched;
    }

    public string GetGenrePreference(){
        return genrePreference;
    }

    public void SetGenrePreference(string genrePreference){
        this.genrePreference = genrePreference;
    }

    public void SetFavorite(string favorite)
    {
        this.favorite = favorite;
    }

    public void SetLeastFavorite(string leastFavorite)
    {
        this.leastFavorite = leastFavorite;
    }
    public abstract string GetFavorite();
    public abstract string GetLeastFavorite();

}