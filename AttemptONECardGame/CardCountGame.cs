using System;
namespace AttemptONECardGame
{
	public class CardCountGame
	{
		CardCountHand player1 = new CardCountHand();
		CardCountHand player2 = new CardCountHand();
		CardCountHand eh = new CardCountHand();

		public void PlayGame()
		{

			//instance of players

			//Card rndCard2 = new Card();

			Console.WriteLine("Card Count Game");


			//Player 1 
			Console.WriteLine("Player 1 Hand");
			//int total;
			for (int i = 0; i < 7; i++)
			{
				Card rndCard = new Card();
				player1.AddCard(new Card());
				Console.WriteLine(i + "-" + rndCard);
			}

			Console.WriteLine("Player 2 Hand");
			for (int i = 0; i < 7; i++)
			{
				Card rndCard2 = new Card();
				player2.AddCard(new Card());
				Console.WriteLine(i + "-" + rndCard2);

			}

			Console.WriteLine("Player1 " + player1.EvaluateHand()
							  + "\nPlayer2 " + player2.EvaluateHand());

			if (player1.EvaluateHand() > player2.EvaluateHand())
			{
				Console.WriteLine("Player 1 wins");
			}
			else if (player1.EvaluateHand() < player2.EvaluateHand())
			{
				Console.WriteLine("Player 2 wins");
			}
			else if (player1.EvaluateHand() == player2.EvaluateHand())
			{
				Console.WriteLine("Tie");
			}
			else {
				Console.WriteLine("Try Again");
			}

		}


	}
}
