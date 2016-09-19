using System;
using System.Collections.Generic;

namespace AttemptONECardGame
{
	//Create a Rank class, which will specify the rank values for a standard deck of cards.
	//Ranks are established in the following ascending order: 2,3,4,5,6,7,8,9,10,J,Q,K,A.
	//The class should define the following static fields:
	//TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE.The
	//class should also define a static field List<Rank>: VALUES, which lists all rank
	//values in the deck. The following methods should be defined:

	// 1. int CompareTo(Rank OtherRankObject): returns 0 if the ranks are the same, -1 if this object has a lower rank than the other object, 1 if this object has a higher rank than the other object.
	// 2. string GetSymbol(): the symbol associated with the rank (e.g. Q)
	// 3. string GetName(): the name associated with the rank (e.g. Queen)
	// 4. string ToString(): the name associated with the rank

	public class Rank
	{
		private int rank;

		public const int ACE = 14;
		public const int KING = 13;
		public const int QUEEN = 12;
		public const int JACK = 11;
		public const int TEN = 10;
		public const int NINE = 9;
		public const int EIGHT = 8;
		public const int SEVEN = 7;
		public const int SIX = 6;
		public const int FIVE = 5;
		public const int FOUR = 4;
		public const int THREE = 3;
		public const int TWO = 2;


		Rank(int initRank)
		{
			rank = initRank;
		}

		public int getRank()
		{
			return rank;
		}

		public int compareTo(Rank compRank)
		{
			if (rank < compRank.getRank())
			{
				return -1;
			}
			else if (rank == compRank.getRank())
			{
				return 0;
			}
			else {
				return 1;
			}
		}
		public string toString()
		{
			switch (rank)
			{
				case JACK:
					return "J";
				case QUEEN:
					return "Q";
				case KING:
					return "K";
				case ACE:
					return "A";
				case TEN:
					return "10";
				case NINE:
					return "9";
				case EIGHT:
					return "8";
				case SEVEN:
					return "7";
				case SIX:
					return "6";
				case FIVE:
					return "5";
				case FOUR:
					return "4";
				case THREE:
					return "3";
				case TWO:
					return "2";
				default:
					return "Error: not a valid rank";
			}

		}

	}
}
