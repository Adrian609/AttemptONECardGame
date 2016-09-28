using System;
using System.Collections.Generic;

namespace AttemptONECardGame
{
	public class Suit
	{
		public string symbol;
		public string name;
		public int val;
		public static Suit CLUBS = new Suit();
		public static Suit DIAMONDS = new Suit();
		public static Suit HEARTS = new Suit();
		public static Suit SPADES = new Suit();

		public static List<Suit> values = new List<Suit> { };

		public Suit(string symbol2, string name2, int val2)
		{
			symbol = symbol2;
			name = name2;
			val = val2;
		}

		public Suit()
		{

		}

		static Suit()
		{
			Suit CLUBS = new Suit("C", "Club", 1);
			Suit DIAMONDS = new Suit("D", "Diamond", 2);
			Suit HEARTS = new Suit("H", "Hearts", 3);
			Suit SPADES = new Suit("S", "Spades", 4);
			values.Add(CLUBS);
			values.Add(DIAMONDS);
			values.Add(HEARTS);
			values.Add(SPADES);
		}


		public int CompareTo(Suit suitObj)
		{
			if (this.val < suitObj.val)
			{
				return -1;
			}

			if (this.val > suitObj.val)
			{
				return 1;
			}
			return 0;
		}

		public string GetSymbol()
		{
			return this.symbol;
		}

		public string GetName()
		{

			return this.name;
		}

		public override string ToString()
		{
			return this.name;
		}


	}
}
