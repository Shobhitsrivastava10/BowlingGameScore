using System.Collections;

namespace BowlingBallScoring.Models
{
	abstract public class Frame
    {
        public ArrayList _throws;
        public int _startingThrow;

        public Frame(ArrayList throws)
        {
            _throws = throws;
            _startingThrow = throws.Count;
        }

        abstract public int Score();
        abstract public int FrameCount();

        public int FirstBonusBall()
        {
            return (int)_throws[_startingThrow + FrameCount()];
        }

        public int SecondBonusBall()
        {
            return (int)_throws[_startingThrow + FrameCount() + 1];
        }
    }
}
