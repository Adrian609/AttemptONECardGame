
namespace AttemptONECardGame
{
	public abstract class Hand
	{
		public Deck deck1 = new Deck(52);
		public int sum = 0;

		public void AddCard(Card newCard)
		{
			deck1.AddCard(newCard);
		}

		public abstract int CompareTo(Hand otherHand);

		public abstract int EvaluateHand();

		public bool ContainsCard(Card aCard)
		{
			if (deck1.deck.Contains(aCard))
			{
				return true;
			}

			return false;
		}

		public void DiscardHand()
		{
			deck1.deck.Clear();
		}

		public int FindCard(Card nuCard)
		{

			return deck1.deck.IndexOf(nuCard);
		}

		public Card GetCardAtIndex(int ind)
		{
			return deck1.deck[ind];
		}

		public int GetNumberOfCards()
		{
			return deck1.deck.Count;
		}

		public bool IsEmpty()
		{
			if (deck1.deck.Count == 0)
			{
				return true;
			}
			return false;
		}
		public Card RemoveCard(Card nuCard)
		{
			deck1.deck.Remove(nuCard);
			return nuCard;
		}

		public Card RemoveCard(int cind)
		{
			deck1.deck.RemoveAt(cind);
			return deck1.deck[cind];
		}
		public override string ToString()
		{
			string sum = "";
			foreach (Card i in deck1.deck)
			{
				sum = sum + " " + i;
			}
			return sum;
		}
	}
}
