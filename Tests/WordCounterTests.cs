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
    [Fact]
    public void WordMatch_SameWord_False()
    {
      string word = "cat";
      string sentence ="dog";
      WordCounter newWordCounter = new WordCounter(word, sentence);
      newWordCounter.WordMatch();
      Assert.Equal(false, newWordCounter.WordMatch());
    }
    [Fact]
    public void SplitToWord_SplitBySpaces_StringA()
    {
      string word = "cat";
      string sentence = "The cat eats cat food";
      WordCounter newWordCounter = new WordCounter(word, sentence);
      newWordCounter.SplitToWord();
      Assert.Equal("The", newWordCounter.SplitToWord()[0]);
    }
    [Fact]
    public void LoopCount_CountRepeats_StringA()
    {
      string word = "cat";
      string sentence = "The cat eats cat food";
      WordCounter newWordCounter = new WordCounter(word, sentence);
      newWordCounter.SplitToWord();
      Assert.Equal(1, newWordCounter.LoopCount());
    }
  }
}
