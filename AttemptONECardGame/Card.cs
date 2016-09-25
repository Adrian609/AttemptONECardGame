namespace AttemptONECardGame
{
	public class Card
	{
		private Rank theRank;
		//private Suit theSuit;


		public Card(int initRank, char initSuit)
		{
			theRank = new Rank(initRank);
			theSuit = new Suit(initSuit);
		}
		public Card()
		{

		}
		public int getRank()
		{
			return theRank.getRank();
		}
		public Suit theSuit { get; set; }

		//Specify the behavior of get/set

		public void ex()
		{
			NumThing = 2;
			int d = NumThing;
		}



		public int NumThing
		{
			get
			{
				return NumThing = NumThing * 2;
			}
			set
			{
				NumThing = value;
			}
		}

		public int compareRank(Card card)
		{
			return theRank.compareTo(card.theRank);
		}
		public virtual string toString()
		{
			return theRank + theSuit.ToString();
		}

	}
}
