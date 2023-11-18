class Scripture // Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
{
    private Reference _reference;
    private Random rng = new();
    private List<Word> _words = new List<Word>(); // Initialize the list

    public Scripture(string text, Reference reference)
    {
        _reference = reference;

        string[] wordsArray = text.Split();
        foreach (string wordString in wordsArray)
        {
            Word wordObj = new Word(wordString);
            _words.Add(wordObj);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index;

            do
            {
                index = rng.Next(_words.Count);
            } while (_words[index].IsHidden());

            _words[index].Hide();
        }
    }

    public void GetDisplayText()
    {
        Console.Write(_reference.GetDisplayText() + ": ");

        foreach (var word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}