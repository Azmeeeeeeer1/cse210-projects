using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split();
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hidden = 0;

        while (hidden < numberToHide)
        {
            int wordToHide = rand.Next(_words.Count);

            if (!_words[wordToHide].IsHidden())
            {
                _words[wordToHide].Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string scripture = "";
        foreach (Word word in _words)
        {
            scripture += word.GetDisplayText() + " ";
        }
        return _reference.GetDisplayText() + scripture;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}