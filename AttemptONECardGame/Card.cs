using System;
namespace AttemptONECardGame
{
	public class Card
	{
		private Rank theRank;
		private Suit theSuit;

		public Card(int initRank, char initSuit)
		{
			theRank = new Rank(initRank);
			theSuit = new Suit(initSuit);
		}
		public int getRank()
		{
			return theRank.getRank();
		}
		public char getSuit()
		{
			return theSuit.getSuit();
		}
		public int compareRank(Card card)
		{
			return theRank.compareTo(card.theRank);
		}
		public string toString()
		{
			return theRank.toString() + theSuit.toString();
		}

	}
}
