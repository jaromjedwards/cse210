using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public JournalEntry(string prompt, string response, DateTime date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }
}

class JournalProgram
{
    private List<JournalEntry> journalEntries = new List<JournalEntry>();

    static void Main()
    {
        JournalProgram journalProgram = new JournalProgram();
        journalProgram.Run();
    }

    void Run()
    {
        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    void WriteNewEntry()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        Console.Write("Your response: ");
        string response = Console.ReadLine();

        JournalEntry newEntry = new JournalEntry(prompt, response, DateTime.Now);
        journalEntries.Add(newEntry);

        Console.WriteLine("Entry saved successfully!\n");
    }

    void DisplayJournal()
    {
        Console.WriteLine("\nJournal Entries:\n");

        foreach (var entry in journalEntries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}\n");
        }
    }

    void SaveJournalToFile()
    {
        Console.Write("Enter a filename to save the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journalEntries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }

            Console.WriteLine("Journal saved to file successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}\n");
        }
    }

    void LoadJournalFromFile()
    {
        Console.Write("Enter a filename to load the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            journalEntries.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] entryParts = reader.ReadLine().Split(',');
                    DateTime date = DateTime.Parse(entryParts[0]);
                    string prompt = entryParts[1];
                    string response = entryParts[2];

                    JournalEntry loadedEntry = new JournalEntry(prompt, response, date);
                    journalEntries.Add(loadedEntry);
                }
            }

            Console.WriteLine("Journal loaded from file successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}\n");
        }
    }

    string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?",
            "Describe a moment that made me laugh today."
            // Add your own prompts here
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
