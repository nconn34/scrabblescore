using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble.Logic;
using Scrabble;
using Classy;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void Scrabble_ReturnsAScore()
    {
    //Arrange
    string word1 = "tin";
  
    //Act
    double score = 3.33;
    double wordScore = ScrabbleGame.Score(word1);

    //Assert
    Assert.AreEqual(wordScore, score);
    
    }

    [TestMethod]
    public void Scrabble_ReturnsAScoreForCaps()
    {
    //Arrange
    string word1 = "TIN";
  
    //Act
    double score = 3.33;
    double wordScore = ScrabbleGame.Score(word1);

    //Assert
    Assert.AreEqual(wordScore, score);
    }

    
    [TestMethod]
    public void Scrabble_ReturnsAScoreForCapsAndAllPoints()
    {
    //Arrange
    string word1 = "ZXKFBDA";
  
    //Act
    double score = 35.41;
    double wordScore = ScrabbleGame.Score(word1);

    //Assert
    Assert.AreEqual(wordScore, score);
    }
  }
}




