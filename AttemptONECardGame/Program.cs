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
			BlackJackGame bg = new BlackJackGame();
			Greeting();
			// play a CardCountGame
			Console.WriteLine("PlayGame Starts");
			bg.PlayBlackJackGame();
			//cg.PlayGame();

			Console.WriteLine("End!!!");

		}
		public static void Greeting()
		{
			Console.WriteLine("Hello, welcome to Blackjack!!!");

		}
	}
}
