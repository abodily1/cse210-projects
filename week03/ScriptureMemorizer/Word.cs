using System;

public class Word
{
    private string _text = ""; 
    private bool _isHidden = false;
    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;

    }
    public bool isHidden()
    { 
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (isHidden())
        {
            // Replace all characters with underscores
            string underscoredWord = new string('_', _text.Length);
            return underscoredWord;
        }
        else 
        {
            return _text;
        }
    }
}