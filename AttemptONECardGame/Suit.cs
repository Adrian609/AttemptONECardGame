using System;
namespace AttemptONECardGame
{
	public class Suit
	{
		private char suit;

		public const char HEARTS = 'H';
		public const char DIAMONDS = 'D';
		public const char CLUBS = 'C';
		public const char SPADES = 'S';

		public Suit(char initSuit)
		{
			suit = initSuit;
		}
		public char getSuit()
		{
			return suit;
		}
		public Boolean equals(Suit compSuit)
		{
			return suit == compSuit.getSuit();
		}
		public string toString()
		{
			return String.valueOf(suit);
		}
	}
}
