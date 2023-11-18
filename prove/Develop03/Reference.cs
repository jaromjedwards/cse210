class Reference // Keeps track of the book, chapter, and verse information.
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public string GetDisplayText()
    {
        if (_endVerse == null)
            return $"{_book} {_chapter}:{_startVerse}";
        else
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }

    // SINGLE VERSE CONSTRUCTOR
    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }

    // MULTI-VERSE CONSTRUCTOR
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
}