using System;


public class Scripture
{
    private Reference _reference;
    private string _text;
    public List<Word> _words = new List<Word>();



   
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;


        string[] words = _text.Split(' '); 

        foreach (var item in words)
        {
            _words.Add(new Word(item)); 
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        
        Random random = new Random();

        int counter = 0; 

        do
        {
            int randomNumber = random.Next(_words.Count); 
            if (!_words[randomNumber].IsHidden()) 
            {
                counter++; 
                _words[randomNumber].Hide();
                if (IsCompletelyHidden())
                {
                    break;
                }
            }
        } while (counter != numberToHide);
    }

    
    public string GetDisplayText()
    {
        
        string _currentVerse = "";

        foreach (Word word in _words) 
        {
            string getText = word.GetDisplayText();
            _currentVerse = _currentVerse + getText; 
        }

        Console.Clear();
        string scripture1 = $"{_reference.GetDisplayText()} {_currentVerse}.";
        return scripture1;
    }
    
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                Console.WriteLine("");
            }
            else
            {
                return false;
            }

        }
          return true;

    }
}