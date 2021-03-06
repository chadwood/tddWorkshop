using System;
namespace Katas
{
    public class TennisGameHard : ITennisGame
    {
		private int p2;
		private int p1;
		private string p1N;
		private string p2N;

		public TennisGameHard(string p1N, string p2N)
		{
			this.p1N = p1N;
			this.p2N = p2N;
		}

		public string GetScore()
		{
			string s;
			if (p1 < 4 && p2 < 4 && !(p1 + p2 == 6))
			{
				string[] p = new string[] { "Love", "Fifteen", "Thirty", "Forty" };
				s = p[p1];
				return (p1 == p2) ? s + "-All" : s + "-" + p[p2];
			}
			else
			{
				if (p1 == p2)
					return "Deuce";
				s = p1 > p2 ? p1N : p2N;
				return ((p1 - p2) * (p1 - p2) == 1) ? "Advantage " + s : "Win for " + s;
			}
		}

		public void WonPoint(string playerName)
		{
			if (playerName == "player1")
				this.p1 += 1;
			else
				this.p2 += 1;

		}
    }
}
