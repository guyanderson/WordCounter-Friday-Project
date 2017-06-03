using Nancy;
using System.Collections.Generic;
using System.Diagnostics;

namespace WordCounter.Project
{
  public class WordCounter
  {
    private string _word;
    private string _sentence;

    public WordCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }

    public int LoopCount()
    {
      int result = 0;
      return result;
    }

    public bool WordMatch()
    {
      bool output = false;
      if (_word == _sentence)
      {
        output = true;
      }
      return output;
    }

    // public string[] GetSplit()
    // {
    //   return SplitToWord();
    // }

    public string[] SplitToWord()
    {
      string[] wordSplit = _sentence.Split(' ');
      return wordSplit;
    }
  }
}
