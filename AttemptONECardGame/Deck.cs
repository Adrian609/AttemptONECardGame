using System;
namespace AttemptONECardGame
{
	//1. void AddCard(card): adds a card to the deck
	//2. Card DealOne(): deal one card from the deck
	//3. int GetCardsRemaining(): returns the number of cards remaining in the current deck
	//4. int GetDeckSize(): returns the size of a full deck of cards
	//5. bool IsEmpty(): returns true if the deck is empty
	//6. void Shuffle(): shuffles the deck of cards that are present in the deck
	//7. void RestoreDeck(): resets the deck back to a full deck, by replacing any cards that were dealt out

	public class Deck
	{
		// A name for an array of references to Playing Card objects.
		// Each reference in this array will hold a reference 
		// to one of the cards in a deck of cards.
		private Card[] theDeck;

		public Deck()
		{
			theDeck = new Card[52];

			for (int i = 0; i < 13; i++)
			{
				theDeck[i]   = new Card(i + 2, Suit.HEARTS);
				theDeck[i+13] = new Card(i + 2, Suit.SPADES);
				theDeck[i+26] = new Card(i + 2, Suit.CLUBS);
				theDeck[i+39] = new Card(i + 2, Suit.DIAMONDS);
			}
		}

		//shuffle
		public void shuffle()
		{
			Card temp;
			int j;
			Random rand = new Random();

			for (int i = 0; i < 52; i++)
			{
				//j = (int)(Math.Random() * 52);
				j = rand.Next(52); 

				temp = theDeck[i];
				theDeck[i] = theDeck[j];
				theDeck[j] = temp;
			}
		}
		//toString
		public string toString()
		{
			string deckStr = " ";

			for (int i = 0; i < 52; i++)
			{
				deckStr = deckStr + theDeck[i].toString() + " ";
			}
			return deckStr;
		}
	}
}
