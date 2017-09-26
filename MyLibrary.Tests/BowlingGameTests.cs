using System;
using Xunit;
//
using MyLibrary;

namespace MyLibrary.Tests
{
  public class BowlingGameTests
  {
    private BowlingGame g;
    
    // The setup function in UT
    public BowlingGameTests()
    {
      g = new BowlingGame();
    }

    [Fact]
    public void DoesGameExists()
    {
      //arrange
      
      //act
      
      // assert
      Assert.NotNull(g);
    }

    [Fact]
    public void GutterGameReturns0()
    {
      //arrange
      //act
      this.rollMany(20, 0);
      // assert
      Assert.Equal(0, g.scoreGame());
    }

    [Fact]
    public void SinglePinGameReturns20()
    {
      //arrange
      int pins = 1;
      //act
      this.rollMany(20, pins);
      // assert
      Assert.Equal(20, g.scoreGame());
    }

  [Fact]
    public void OnSpareReturnsAppropriateValue()
    {
      //arrange
      g.roll(5);
      g.roll(5);   // spare
      g.roll(3);
      
      //act
      this.rollMany(17, 0);
      // assert
      Assert.Equal(16, g.scoreGame());
    }


    private void rollMany(int rolls, int pins)
    {
      for(int i = 0; i< rolls; i++)
      {
        g.roll(pins);
      }
    }
  }
}