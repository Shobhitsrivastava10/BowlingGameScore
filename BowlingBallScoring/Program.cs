using BowlingBallScoring.Core;
using System;

namespace BowlingBallScoring
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to bowling game score");
			var game = new BowlingGame();

			for(int i=1;i<=10;i++)
			{
				Console.WriteLine($"Enter first throw for {i} frame");
				int firstroll =int.Parse(Console.ReadLine());

				if(firstroll<10)
				{
					Console.WriteLine($"Enter second throw for {i} frame");
					int secondRoll = int.Parse(Console.ReadLine());
					game.OpenFrame(firstroll, secondRoll);

					// bonus roll is given in last frame incase of strike/spare
					if (i == 10 && (firstroll+secondRoll) == 10)
					{
						Console.WriteLine($"Enter first bonus throw");
						int firstBonusRoll = int.Parse(Console.ReadLine());
						game.BonusRoll(firstBonusRoll);
					}
				}
				else
				{
					game.Strike();
					if(i == 10)
					{
						Console.WriteLine($"Enter first bonus throw");
						int firstBonusRoll = int.Parse(Console.ReadLine());
						game.BonusRoll(firstBonusRoll);

						Console.WriteLine($"Enter second bonus throw");
						int secondBonusRoll = int.Parse(Console.ReadLine());
						game.BonusRoll(secondBonusRoll);
					}
				}				
			}
			Console.WriteLine("Final Score is: " + game.Score());
		}
	}
}
