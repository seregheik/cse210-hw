public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference Reference, string text)
    {
      _reference = Reference;
      string[] words = text.Split(" ");
      foreach (string item in words)
        {
            Word newWord = new Word(item);
            _words.Add(newWord);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words.FindAll(word => !word.IsHidden());
        
        if (visibleWords.Count <= numberToHide)
        {
            foreach (var word in visibleWords)
            {
                word.Hide();
            }
            return;
        }

        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
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