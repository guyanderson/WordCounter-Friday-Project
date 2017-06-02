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
    public bool WordMatch()
    {
      bool output = false;
      if (_word == _sentence)
      {
        output = true;
      }
      return output;
    }
  }
}
