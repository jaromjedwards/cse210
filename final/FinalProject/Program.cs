using System;

class Program
{
    static void Main(string[] args)
    {

        // Get Person Information
        Person person = new Person();
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        person.setFirstName(firstName);

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();
        person.setlastName(lastName);

        Console.WriteLine("What is your gender? (Type: M or F)");
        string gender = Console.ReadLine();
        person.setGender(gender);

        Console.WriteLine("What is your age?");
        string aInput = Console.ReadLine();
        if (int.TryParse(aInput, out int age))
        {
            person.setAge(age);
        }
        else
        {
            Console.WriteLine("Invalid age input. Please enter a valid integer.");
        }

        // Ask what Survey they are taking
        Console.WriteLine($"Welcome {firstName}! Which survey would you like to take?\n1. Pixar Movies \n2. Disney Princess Movies \n3. DreamWorks Movies");
        string userChoice = Console.ReadLine();
        Console.WriteLine($"Survey has started. First, let's start with some general questions:");

        // get general Movie Survey responses
        MovieSurvey movieSurvey = new MovieSurvey();
        Console.WriteLine("Where do you mainly watch movies?");
        string locationWatched = Console.ReadLine();
        movieSurvey.SetLocationWatched(locationWatched);

        Console.WriteLine("How many hours a week do you watch movies? (Do not include hours watched TV shows, YouTube, Media content etc");
        string hInput = Console.ReadLine();
        if (int.TryParse(hInput, out int weeklyHoursWatched))
        {
            movieSurvey.SetWeeklyHoursWatched(weeklyHoursWatched);
        }
        else
        {
            Console.WriteLine("Invalid age input. Please enter a valid integer.");
        }

        Console.WriteLine("What is your prefered genre of movies?");
        string genrePreference = Console.ReadLine();
        movieSurvey.SetGenrePreference(genrePreference);


        if (userChoice == "1"){
            Console.WriteLine($"Great! Now onto the Pixar Movie Specific questions");

            PixarMovieSurvey pixar = new PixarMovieSurvey();
            IReadOnlyList<string> pixarMovies = pixar.GetPixarMovies();
            foreach (string movie in pixarMovies){
                Console.WriteLine(movie);
            }

        }

    }
}