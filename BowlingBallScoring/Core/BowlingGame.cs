using BowlingBallScoring.Models;
using System.Collections;

namespace BowlingBallScoring.Core
{
	public class BowlingGame
	{
		public readonly ArrayList _throws;
		public readonly ArrayList _frames;

		public BowlingGame()
		{
			_throws = new ArrayList();
			_frames = new ArrayList();
		}

		public void OpenFrame(int firstThrow, int secondThrow)
		{
			_frames.Add(new OpenFrame(_throws, firstThrow, secondThrow));
		}

		public void Spare(int firstThrow, int secondThrow)
		{
			_frames.Add(new SpareFrame(_throws, firstThrow, secondThrow));
		}

		public void Strike()
		{
			_frames.Add(new StrikeFrame(_throws));
		}

		public void BonusRoll(int roll)
		{
			_frames.Add(new BonusRoll(_throws, roll));
		}

		public int Score()
		{
			int total = 0;
			foreach (Frame frame in _frames)
			{
				total += frame.Score();
			}
			return total;
		}
	}
}
