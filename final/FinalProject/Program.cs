using System;

// Abstraction: Abstract classes such as Person and MovieSurveys.
// Encaptulation: Person encaptulates firstName, lastName, gender and age. 
// Inheritance: PixarMovieSurvey, DisneyMovieSurvey, and DreamworksMovieSurvey inherit functionality/properties from MovieSurvey.
// Polymorphism: MovieSurvey holds favorite and least favorite, Pixar/Disney/DreamworksSurvey override


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

        // Get general Movie Survey responses
        Console.WriteLine("Where do you mainly watch movies?");
        string locationWatched = Console.ReadLine();
        Console.WriteLine("How many hours a week do you watch movies? (Do not include hours watched TV shows, YouTube, Media content etc");
        string hInput = Console.ReadLine();
        Console.WriteLine("What is your prefered genre of movies?");
        string genrePreference = Console.ReadLine();

        // ask specific Pixar/Disney/Dreamworks questions
        if (userChoice == "1"){
            Console.WriteLine($"Great! Now onto the Pixar Movie Specific questions");

            // Set General Movie Responses
            PixarMovieSurvey pixar = new PixarMovieSurvey();
            pixar.SetLocationWatched(locationWatched);
            pixar.SetGenrePreference(genrePreference);
            if (int.TryParse(hInput, out int weeklyHoursWatched))
            {
                pixar.SetWeeklyHoursWatched(weeklyHoursWatched);
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid integer.");
            }

            // Get Pixar movie list
            IReadOnlyList<string> pixarMovies = pixar.GetPixarMovies();
            Console.WriteLine("Pixar Movies: " + string.Join(", ", pixarMovies));

            // Get Pixar Movie Responses
            Console.WriteLine($"What is your favorite Pixar movie?");
            string favorite = Console.ReadLine();

            Console.WriteLine($"What is your least favorite Pixar movie?");
            string leastFavorite = Console.ReadLine();

        }
        if (userChoice == "2"){
            Console.WriteLine($"Great! Now onto the Disney Movie Specific questions");

            // Set General Movie Responses
            DisneyMovieSurvey disney = new DisneyMovieSurvey();
            disney.SetLocationWatched(locationWatched);
            disney.SetGenrePreference(genrePreference);
            if (int.TryParse(hInput, out int weeklyHoursWatched))
            {
                disney.SetWeeklyHoursWatched(weeklyHoursWatched);
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid integer.");
            }

            // Get Disney movie list
            IReadOnlyList<string> disneyMovies = disney.GetDisneyMovies();
            Console.WriteLine("Disney Movies: " + string.Join(", ", disneyMovies));

            // Get Disney Movie Responses
            Console.WriteLine($"What is your favorite Disney movie?");
            string favorite = Console.ReadLine();

            Console.WriteLine($"What is your least favorite Disney movie?");
            string leastFavorite = Console.ReadLine();

        }
        if (userChoice == "3"){
            Console.WriteLine($"Great! Now onto the Dreamworks Movie Specific questions");

            // Set General Movie Responses
            DreamworksMovieSurvey dreamworks = new DreamworksMovieSurvey();
            dreamworks.SetLocationWatched(locationWatched);
            dreamworks.SetGenrePreference(genrePreference);
            if (int.TryParse(hInput, out int weeklyHoursWatched))
            {
                dreamworks.SetWeeklyHoursWatched(weeklyHoursWatched);
            }
            else
            {
                Console.WriteLine("Invalid age input. Please enter a valid integer.");
            }

            // Get Dreamworks movie list
            IReadOnlyList<string> dreamworksMovies = dreamworks.GetDreamworksMovies();
            Console.WriteLine("Dreamworks Movies: " + string.Join(", ", dreamworksMovies));

            // Get Dreamworks Movie Responses
            Console.WriteLine($"What is your favorite Dreamworks movie?");
            string favorite = Console.ReadLine();

            Console.WriteLine($"What is your least favorite Dreamworks movie?");
            string leastFavorite = Console.ReadLine();

        }

    }
}