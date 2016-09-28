using System;
using System.Linq;

namespace AttemptONECardGame
{
	class MainClass
	{


		public static void Main(string[] args)
		{
			Card obj = new Card();
			CardCountGame cg = new CardCountGame();
			Greeting();

			Console.WriteLine("Suite:" + obj.GetSuit() + " Rank: " + obj.GetRank() + "Object To String " + obj.ToString());

			Console.WriteLine("Homework 2 Output");

			// instantiate some cards
			Card c1 = new Card(Suit.HEARTS, Rank.TWO);
			Card c2 = new Card(Suit.HEARTS, Rank.TWO);
			Card c3 = new Card(Suit.CLUBS, Rank.FOUR);
			Card c4 = new Card(Suit.CLUBS, Rank.JACK);
			Card c5 = new Card(Suit.DIAMONDS, Rank.ACE);

			// play a CardCountGame
			Console.WriteLine("PlayGame Starts");
			cg.PlayGame();

			Console.WriteLine("End!!!");

		}
		public static void Greeting()
		{
			Console.WriteLine("Hello, welcome to Blackjack!!!");

		}
	}
}
