using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _text;
    private Reference _reference;
    public Scripture(Reference reference , string text)
    {
        _reference = reference;
        _text = text;
        List<string> words = new List<string>(text.Split(' '));
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }
    public string GetDisplayText()
    {
        string allWords = "";
        foreach (Word word in _words)
        {
            string result = word.GetDisplayText();
            allWords += " " + result; 
        } 
        return allWords;
    }
    public void HideRandomWords(int numberToHide)
    {
        int count = 0;
        while (count < numberToHide)
        {
            // Get random number between 0 and the length of the list of Words
            Random random = new Random();
            int number = random.Next(0, _words.Count());
            
            // Check if word is already hidden
            if (!_words[number].isHidden())
            {
                _words[number].Hide();
                count += 1;
            }
            // Handle case where all words are hidden and count is < numberToHide
            if(IsCompletelyHidden())
            {
                break;
            }
        }
    }   
    public bool IsCompletelyHidden()
    {
        int n = _words.Count();
        for (int i = 0; i < n; i++)
        {
            if (!_words[i].isHidden())
            {
                return false;
            }       
        }
        return true;
    }
}