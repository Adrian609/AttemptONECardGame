using System;
using System.Collections.Generic;

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
		public int deckSize;
		public List<Card> deck;
		Random rnd = new Random();

		public Deck(int deckSize2)
		{
			deck = new List<Card> { };
			deckSize = deckSize2;
		}

		public void AddCard(Card newCard)
		{
			if (deck.Count < deckSize)
			{
				deck.Add(newCard);
			}

		}

		public Card DealOne()
		{
			int rnd1 = rnd.Next(0, deck.Count);
			Card temp = deck[rnd1];
			deck.RemoveAt(rnd1);
			return temp;
		}

		public int GetCardsRemaining()
		{
			return deck.Count;
		}

		public int GetDeckSize()
		{

			return deckSize;
		}

		public bool IsEmpty()
		{
			if (deck.Count == 0)
			{
				return true;
			}
			return false;
		}

		public void Shuffle()
		{
			List<Card> temp = deck;
			int temprnd;
			int count = 0;

			deck.Clear();

			while (count <= temp.Count)
			{
				temprnd = rnd.Next(0, temp.Count);

				if (!deck.Contains(temp[temprnd]))
				{
					this.AddCard(temp[temprnd]);
					count++;
				}
			}
		}

		public void RestoreDeck()
		{
			Card temp;

			for (int i = deck.Count; i <= 52; i++)
			{
				temp = new Card();
				this.AddCard(temp);
			}
		}
	}
}
