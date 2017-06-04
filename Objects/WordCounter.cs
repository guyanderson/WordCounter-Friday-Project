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
      string[] wordSplit = _sentence.Split(' ');
      return wordSplit;
    }
//=========================================    
  }
}
