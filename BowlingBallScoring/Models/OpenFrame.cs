using System.Collections;

namespace BowlingBallScoring.Models
{
    /// <summary>
    /// Hit some balls in 2 shots of a frame
    /// </summary>
	public class OpenFrame : Frame
    {
        public OpenFrame(ArrayList throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        /// <summary>
        /// final score will be decided by the last frame shot
        /// </summary>
        /// <returns></returns>
        override public int Score()
        {
            var score = (int)_throws[_startingThrow] + (int)_throws[_startingThrow + 1];
            
            // Check whether this open frame is also a spare frame or not
            if (score == 10)
            {
                return 10 + FirstBonusBall();
            }
            else
            {
                return score;
            }
        }

        override public int FrameCount()
        {
            return 2;
        }
    }
}
