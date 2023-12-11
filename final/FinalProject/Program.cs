using System;
using System.IO;
using System.Collections.Generic;


// Abstraction: Abstract classes such as Person and MovieSurveys.
// Encaptulation: Person encaptulates firstName, lastName, gender and age. 
// Inheritance: PixarMovieSurvey, DisneyMovieSurvey, and DreamworksMovieSurvey inherit functionality/properties from MovieSurvey.
// Polymorphism: MovieSurvey holds favorite and least favorite, Pixar/Disney/DreamworksSurvey override


class Program
{
    static void Main(string[] args)
    {
        // declare txt files
        string pixarFile = "pixar.txt";
        string disneyFile = "disney.txt";
        string dreamworksFile = "dreamworks.txt";

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

        // declare
        string locationWatched = "";
        string genrePreference = "";
        string hInput = "";

        // PIXAR
        if (userChoice == "1"){

            ProcessFile(pixarFile, firstName, lastName, gender, age);
            askGeneralQuestions(ref locationWatched, ref genrePreference, ref hInput);

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

            // Print responses on pixar.txt
            using (StreamWriter writer = new StreamWriter(pixarFile, true))
            {
                writer.WriteLine($"{firstName},{lastName},{gender},{age},{locationWatched},{genrePreference},{weeklyHoursWatched},{favorite},{leastFavorite}");
            }
            Console.WriteLine("Text has been written to the file: " + pixarFile);

        }
        //DISNEY
        if (userChoice == "2"){

            ProcessFile(disneyFile, firstName, lastName, gender, age);
            askGeneralQuestions(ref locationWatched, ref genrePreference, ref hInput);

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

            // Print responses on disney.txt
            using (StreamWriter writer = new StreamWriter(disneyFile, true))
            {
                writer.WriteLine($"{firstName},{lastName},{gender},{age},{locationWatched},{genrePreference},{weeklyHoursWatched},{favorite},{leastFavorite}");
            }
            Console.WriteLine("Text has been written to the file: " + disneyFile);

        }
        // DREAMWORKS
        if (userChoice == "3"){

            ProcessFile(dreamworksFile, firstName, lastName, gender, age);
            askGeneralQuestions(ref locationWatched, ref genrePreference, ref hInput);

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

            // Print responses on dreamworks.txt
            using (StreamWriter writer = new StreamWriter(dreamworksFile, true))
            {
                writer.WriteLine($"{firstName},{lastName},{gender},{age},{locationWatched},{genrePreference},{weeklyHoursWatched},{favorite},{leastFavorite}");
            }
            Console.WriteLine("Text has been written to the file: " + dreamworksFile);

        }

        static void askGeneralQuestions(ref string locationWatched, ref string genrePreference, ref string hInput){
            Console.WriteLine($"Survey has started. First, let's start with some general questions:");
            // Get general Movie Survey questions
            Console.WriteLine("Where do you mainly watch movies?");
            locationWatched = Console.ReadLine();

            Console.WriteLine("What is your prefered genre of movies?");
            genrePreference = Console.ReadLine();

            Console.WriteLine("How many hours a week do you watch movies? (Do not include hours watched TV shows, YouTube, Media content etc");
            hInput = Console.ReadLine();
        }
static bool ProcessFile(string filePath, string firstName, string lastName, string gender, int age)
{
    // Check if the file exists
    if (File.Exists(filePath)){
        // Read all lines from the file
        string[] lines = File.ReadAllLines(filePath);

        // Process each line
        foreach (string line in lines)
        {
            // Split the line using commas as separators
            string[] items = line.Split(',');

            if (items.Length >= 4)
            {
                string item1 = items[0];
                string item2 = items[1];
                string item3 = items[2];

                if (int.TryParse(items[3], out int item4))
                {
                    // Check for a match after parsing item4
                    if (item1 == firstName && item2 == lastName && item3 == gender && item4 == age)
                    {
                        Console.WriteLine("You have already taken this survey! Please choose a different survey to take");
                        return true;
                    }
                }
            }
            }
            // If the loop completes without finding a match, the survey hasn't been taken
            return false;
            }
            // If the file doesn't exist, the survey hasn't been taken
            return false;
        }

    }
}

