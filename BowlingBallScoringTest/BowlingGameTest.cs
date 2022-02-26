using BowlingBallScoring;
using NUnit.Framework;

namespace BowlingBallScoringTest
{
	/// <summary>
	/// Unit test for the Bowling game
	/// </summary>
	public class BowlingGameTest
	{
		private BowlingGame _game;
		
		[SetUp]
		public void Setup()
		{
			_game = new BowlingGame();
		}

		#region Test scenarios
		/// <summary>
		/// No ball is pinned in any frame
		/// </summary>
		[Test]
		public void GutterBalls()
		{
			OpenFramesThrow(10, 0, 0);
			Assert.AreEqual(0, _game.Score());
		}

		/// <summary>
		/// No strike/spare in any frame
		/// </summary>
		[Test]
		public void OpenFramesGame()
		{
			OpenFramesThrow(10, 4, 2);
			Assert.AreEqual(60, _game.Score());
		}
		
		/// <summary>
		/// strike in first frame with remaning open frames
		/// </summary>
		[Test]
		public void FirstFrameStrike()
		{
			_game.Strike();
			_game.OpenFrame(5, 3);
			OpenFramesThrow(8, 0, 0);
			Assert.AreEqual(26, _game.Score());
		}

		/// <summary>
		/// strike in last frame with remaning open frames
		/// </summary>
		[Test]
		public void FinalFrameStrike()
		{
			OpenFramesThrow(9, 0, 0);
			_game.Strike();
			_game.BonusRoll(5);
			_game.BonusRoll(3);
			Assert.AreEqual(18, _game.Score()); 
		}

		/// <summary>
		/// spare in first frame with remaning open frames
		/// </summary>
		[Test]
		public void FirstFrameSpare()
		{
			_game.Spare(4, 6);
			_game.OpenFrame(3, 5);
			OpenFramesThrow(8, 0, 0);
			Assert.AreEqual(21, _game.Score());
		}

		/// <summary>
		/// spare in last frame with remaning open frames
		/// </summary>
		[Test]
		public void FinalFrameSpare()
		{
			OpenFramesThrow(9, 0, 0);
			_game.Spare(4, 6);
			_game.BonusRoll(5);
			Assert.AreEqual(15, _game.Score());
		}

		/// <summary>
		/// Strike in all frames
		/// </summary>
		[Test]
		public void PerfectGame()
		{
			for (int i = 0; i < 10; i++)
			{
				_game.Strike();
			}
			_game.BonusRoll(10);
			_game.BonusRoll(10);
			Assert.AreEqual(300, _game.Score());
		}

		/// <summary>
		/// Alternate strike and spare in all frames
		/// </summary>
		[Test]
		public void StrikeAndSpare()
		{
			for (int i = 0; i < 5; i++)
			{
				_game.Strike();
				_game.Spare(5, 5);
			}
			_game.BonusRoll(10);
			Assert.AreEqual(200, _game.Score());
		}

		#endregion

		#region Private Methods
		/// <summary>
		/// It will add open frames with first throw and second throw values
		/// </summary>
		/// <param name="count"></param>
		/// <param name="firstThrow"></param>
		/// <param name="secondThrow"></param>
		private void OpenFramesThrow(int count, int firstThrow, int secondThrow)
		{
			for (int frameNumber = 0; frameNumber < count; frameNumber++)
				_game.OpenFrame(firstThrow, secondThrow);
		}

		#endregion

	}
}