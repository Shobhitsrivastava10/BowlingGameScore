using System.Collections;

namespace BowlingBallScoring.Models
{
    /// <summary>
    /// Hit 10 balls in 2 shots of a frame
    /// </summary>
    public class SpareFrame : Frame
    {
        public SpareFrame(ArrayList throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        /// <summary>
        /// Final score includes first bonus roll
        /// </summary>
        /// <returns></returns>
        override public int Score()
        {
            return 10 + FirstBonusBall(); 
        }

        override public int FrameCount()
        {
            return 2;
        }
    }
}
