using System;
namespace AttemptONECardGame
{
	public class CardCountGame
	{
		CardCountHand player1 = new CardCountHand();
		CardCountHand player2 = new CardCountHand();

		public void PlayGame()
		{
			Card rndCard = new Card();
			Card rndCard2 = new Card();



			player1.AddCard(rndCard);
			player2.AddCard(rndCard2);
			Console.WriteLine(rndCard.ToString() + " " + rndCard2.ToString());

		}


	}
}
