using System;

namespace AttemptONECardGame
{
	public class Card
	{
		public Suit mySuit;
		public Rank myRank;
		static Random rnd = new Random();
		public int rndval = rnd.Next(0, 13);
		public int rndval2 = rnd.Next(0, 3);

		public Card(Suit newSuit, Rank newRank)
		{
			mySuit = newSuit;
			myRank = newRank;
		}

		public Card()
		{
			myRank = Rank.values[rndval];
			mySuit = Suit.values[rndval2];
		}


		public int CompareTo(Card newCard)
		{
			return this.myRank.CompareTo(newCard.myRank);
		}

		public Rank GetRank()
		{
			return myRank;
		}

		public Suit GetSuit()
		{

			return mySuit;
		}

		public override string ToString()
		{
			return "Rank is: " + myRank + " Suit is: " + mySuit;

		}

	}
}
