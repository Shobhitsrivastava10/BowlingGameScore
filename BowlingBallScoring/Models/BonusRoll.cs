using System.Collections;

namespace BowlingBallScoring.Models
{
    /// <summary>
    /// Bonus roll comes into picture when player hit strike/spare in last frame
    /// </summary>
	public class BonusRoll : Frame
    {
        public BonusRoll(ArrayList throws, int firstThrow) : base(throws)
        {
            throws.Add(firstThrow);
        }

        override public int Score()
        {
            return 0;
        }


        /// <summary>
        /// Frame count is 0 as this is bonus roll in last frame incase of strike/spare
        /// </summary>
        /// <returns></returns>
        override public int FrameCount()
        {
            return 0;
        }
    }
}
