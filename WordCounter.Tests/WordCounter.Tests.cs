using Microsoft.TestTools;
using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
  [TestMethod]
public class MatchWordTest;
  {
public void IsWordCounter_FullWordTrue()
    {

WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }

[TestMethod]
public void IsWordCounter_PunctuationNotNecessaryTrue()
    {
  WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }

[TestMethod]

public void stringsIsWordCounter_NumberTrue()
    {
  WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }

[TestMethod]
public void stringsIsWordCounter_CapitalizationNotNecessary()
    {
  WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }

[TestMethod]
public void stringsIsWordCounter_NoSymbolsTrue()
    {
  WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }
}
