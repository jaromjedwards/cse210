class Word // Keeps track of a single word and whether it is shown or hidden.
{
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return _hiddenText;
        }
        else
        {
            return _text;
        }
    }

    private string _text;
    private string _hiddenText;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
        _hiddenText = "";

        foreach (char letter in text)
        {
            _hiddenText += "_";
        }
    }
}