using System.Collections;

namespace BowlingBallScoring.Models
{
    /// <summary>
    /// Hit 10 balls in 1 shot of a frame
    /// </summary>
    public class StrikeFrame : Frame
    {
        public StrikeFrame(ArrayList throws) : base(throws)
        {
            throws.Add(10);
        }

        /// <summary>
        /// Final score will include both bonus rolls
        /// </summary>
        /// <returns></returns>
        override public int Score()
        {
            return 10 + FirstBonusBall() + SecondBonusBall();
        }

        /// <summary>
        /// For strike shot there will be only 1 frame.
        /// </summary>
        /// <returns></returns>
        override public int FrameCount()
        {
            return 1;
        }
    }
}
