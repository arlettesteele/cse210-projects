//I added a reset option//
using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string scriptureText)
    {
         _reference = Reference;
         _words = new List<Word>();

         foreach (string word in scriptureText.Split(' '))
         {
            _words.Add(new Word(word));
         }
    }
    public void HideRandomWords(int numbertoHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numbertoHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        string displayText = (_reference.GetDisplayText() + " ");

        displayText += string.Join(" ", _words.ConvertAll(word => word.GetDisplayText()));

        return displayText;
    }


    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void ResetScripture()
    {
        foreach (var word in _words)
        {
            word.Show();
        }
    }
}