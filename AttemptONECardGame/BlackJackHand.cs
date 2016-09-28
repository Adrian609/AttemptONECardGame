
namespace AttemptONECardGame
{
	public class BlackJackHand : Hand
	{

		public override int CompareTo(Hand otherHand)
		{
			if (this.EvaluateHand() > otherHand.EvaluateHand())
			{
				return 1;
			}
			else if (this.EvaluateHand() < otherHand.EvaluateHand())
			{
				return -1;
			}
			else
				return 0;
		}


		public override int EvaluateHand()
		{
			int count = 0;
			foreach (Card i in deck1.deck)
			{
				sum += deck1.deck[count].GetRank().val;
			}

			return sum;
		}


	}
}
