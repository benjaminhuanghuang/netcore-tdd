using System;

namespace MyLibrary
{
    public class BowlingGame
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void roll(int pins)
        {
          rolls[currentRoll] = pins;
          currentRoll ++;
        }
        public int scoreGame()
        {
          int score = 0;
          int frameIndex = 0;
          for(int frame =0; frame < 10 ; frame ++)
          {
            if(IsStrike(frameIndex))
            {
              score += 10 + strikeBonus(frameIndex);
              frameIndex += 1;
            }
            else if(IsSpare(frameIndex))
            {
              score += 10 + rolls[frameIndex+2];
              frameIndex += 2;
            }
            else
            {
              score += rolls[frameIndex] + rolls[frameIndex+1];
              frameIndex += 2; 
            }
          }
          return score;
        }

      private bool IsSpare(int frameIndex)
      {
        return rolls[frameIndex] + rolls[frameIndex+1] == 10;
      }

      private bool IsStrike(int frameIndex)
      {
        return rolls[frameIndex] == 10;
      }

      private int strikeBonus(int frameIndex)
      {
        return (rolls[frameIndex + 1] + rolls[frameIndex + 2]);
      }
    }
}
