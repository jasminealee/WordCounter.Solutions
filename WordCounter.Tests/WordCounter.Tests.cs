using Microsoft.TestTools;
using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
  [TestMethod]
public class MatchWordTest;
  {
public void stringIsWordCounter_FullWordTrue()
    {

WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }

[TestMethod]
public void string























































































































































 





















































































































?IsWordCounter_PunctuationNotNecessaryTrue()
    {
  WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }

[TestMethod]

public void stringIsWordCounter_NumberTrue()
    {
  WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }

[TestMethod]
public void stringIsWordCounter_CapitalizationNotNecessary()
    {
  WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }

[TestMethod]
public void stringIsWordCounter_NoSymbolsTrue()
    {
  WordCounter testWordCounter = new WordCounter();
  Assert.AreEqual(true, testWordCounter.IsWordCounter(pen));
    }
}
