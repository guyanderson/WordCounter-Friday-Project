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
//=========================================
    // public string strip()
    // {
    //   string[] word = ToLower()
    // }
//=========================================
    public string GetWord()
    {
      return _word;
    }
//=========================================
    public string GetSentence()
    {
      return _sentence;
    }
//=========================================
    public int GetResult()
    {
      return LoopCount();
    }
//=========================================
    public int LoopCount()
    {
      string[] word = SplitToWord();
      int result = 0;
      for(int i = 0; i < word.Length; i++)
      {
        if(WordMatch(word[i]))
        {
          result += 1;
        }
      }
      return result;
    }
//=========================================
    public bool WordMatch( string input)
    {
      bool output = false;
      if (input == _word)
      {
        output = true;
      }
      return output;
    }
//=========================================
    public string[] SplitToWord()
    {
      string[] wordSplit = _sentence.ToLower().Replace(".", "").Replace(",", "").Replace("!", "").Replace("?", "").Split(' ');
      return wordSplit;
    }
//=========================================
  }
}
