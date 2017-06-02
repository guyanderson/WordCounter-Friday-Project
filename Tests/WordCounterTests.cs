// using Nancy;
using Xunit;
// using System.Collections.Generic;
// using System.Diagnostics;

namespace WordCounter.Project
{
  public class WordCounterTests
  {
    [Fact]
    public void WordMatch_SameWord_True()
    {
      string word = "cat";
      string sentence ="cat";
      WordCounter newWordCounter = new WordCounter(word, sentence);
      newWordCounter.WordMatch();
      Assert.Equal(true, newWordCounter.WordMatch());
    }
  }
}
