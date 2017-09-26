using System;
using Xunit;
//
using MyLibrary;

namespace MyLibrary.Tests
{
  public class BowlingGameTests
  {
    [Fact]
    public void DoesGameExists()
    {
      //arrange
      var g = new BowlingGame();
      //act
      
      // assert
      Assert.NotNull(g);
    }
  }
}