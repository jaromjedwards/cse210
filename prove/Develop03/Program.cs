class Program
{
    static void Main()
    {
        Reference reference = new Reference("3 Nephi", "17", "7");
        Scripture scripture = new Scripture("Have ye any that are sick among you? Bring them hither. Have ye any that are lame, or blind, or halt, or maimed, or leprous, or that are withered, or that are deaf, or that are afflicted in any manner? Bring them hither, and I will heal them, for I have compassion upon you; my bowels are filled with mercy.", reference);

        int numberToHide;

        // Get the number of words to hide from the user
        Console.Write("How many words would you like to hide at a time? ");
        while (!int.TryParse(Console.ReadLine(), out numberToHide))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("How many words would you like to hide at a time? ");
        }

        while (true)
        {
            // Display the scripture text
            scripture.GetDisplayText();

            // Ask the user to continue or quit
            Console.Write("Press 'enter' to continue or type 'quit' to close: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Exciting!");
                break;
            }

            // Hide random words
            scripture.HideRandomWords(numberToHide);
        }
    }
}
