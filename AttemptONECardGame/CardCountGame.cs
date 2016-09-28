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
			int sum = 0;
			//int total;
			for (int i = 0; i < 7; i++)
			{
				Card rndCard = new Card();
				player1.AddCard(new Card());
				Console.WriteLine("- " + rndCard);
				sum += rndCard.rndval;
				Console.WriteLine(sum);
			}
			Console.WriteLine("Player 1 total " + sum);
			//Player 2
			Console.WriteLine("Player 2 Hand");
			for (int i = 0; i < 7; i++)
			{
				Card rndCard2 = new Card();
				player2.AddCard(new Card());
				Console.WriteLine("- " + rndCard2);
				sum += rndCard2.rndval2;
				Console.WriteLine(sum);

			}
			Console.WriteLine("Player 2 total " + sum);
			Console.WriteLine("Evaluate Players hands");
			player2.EvaluateHand().CompareTo(player1);

		}


	}
}
