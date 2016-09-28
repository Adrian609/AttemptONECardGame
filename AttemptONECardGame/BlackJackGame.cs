using System;
namespace AttemptONECardGame
{
	public class BlackJackGame
	{

		BlackJackHand player1 = new BlackJackHand();
		BlackJackHand comp = new BlackJackHand();
		public void PlayBlackJackGame()
		{
			Card rndCard = new Card();
			Card rndCard2 = new Card();

			int caseSwitch;
			char ch;
			Console.WriteLine("Welcome to Blackjack!\n" +
							  "You have been dealt" + rndCard + "\n" +
							  "You have been dealt" + rndCard2 + "\n" +
							  "Evaluated Hand:" + player1.EvaluateHand() + "\n" +
							  "Hit or Stand (H/S)?");
			player1.AddCard(new Card());
			Console.Read();
			caseSwitch = Console.Read();
			ch = Convert.ToChar(caseSwitch);
			switch (caseSwitch)
			{
				case 'H':
					player1.AddCard(new Card());
					Console.WriteLine("HIT");
					Console.WriteLine(rndCard + "\n Evaluated Hand: " + player1.EvaluateHand());
					break;
				case 'S':
					Console.WriteLine("Stay" +
									  "Evaluated Hand: " + player1.EvaluateHand());
					break;
				default:
					Console.WriteLine("Default case");
					break;
			}

			Card comp1 = new Card();
			Card comp2 = new Card();

			Console.WriteLine("Computer");
			Console.WriteLine("Welcome to Blackjack!\n" +
							  "You have been dealt" + comp1 + "\n" +
							  "You have been dealt" + comp2 + "\n" +
							  "Evaluated Hand:" + comp.EvaluateHand() + "\n" +
							  "Hit or Stand (H/S)?");
			if (comp.EvaluateHand() < 17)
			{
				comp.AddCard(new Card());
				Console.WriteLine("HIT");
				Console.WriteLine(comp1 + "\n Evaluated Hand: " + comp.EvaluateHand());
			}
			else if (comp.EvaluateHand() > 21)
			{
				Console.WriteLine("Bust " + comp.EvaluateHand());
			}
			else {
				Console.WriteLine("Stay " + comp.EvaluateHand());
			}

			if (comp.EvaluateHand() > player1.EvaluateHand())
			{
				Console.WriteLine("Computer Wins");
			}
			else if (comp.EvaluateHand() < player1.EvaluateHand())
			{
				Console.WriteLine("Player 1 wins");
			}
			else {
				Console.WriteLine("Tie");
			}

		}
	}
}
