using System;
using System.Linq;

namespace AttemptONECardGame
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			CardCountGame cg = new CardCountGame();
			BlackJackGame bg = new BlackJackGame();
			int selection;
			char ch;

			Greeting();

			selection = Console.Read();
			ch = Convert.ToChar(selection);

			switch (ch.ToString().ToUpper())
			{
				case "A":
					Console.WriteLine("You selected BlackJack");
					bg.PlayBlackJackGame();
					break;
				case "B":
					Console.WriteLine("You selected Counting Cards game");
					cg.PlayGame();
					break;
				case "Q":
					Console.WriteLine("QUIT");
					break;
				default:
					Console.WriteLine("Please enter a valid selection");
					break;
			}

			Console.WriteLine("End!!!");



		}
		public static void Greeting()
		{
			Console.WriteLine("Hello, welcome to Blackjack / Counting Cards!!!\n" +
							 "please press A,B or Q for Black Jack, Counting cards or to Quit+\n" +
							  "A) Black Jack \n" +
							  "B) Counting Cards \n" +
							  "Q) Quit \n");

		}
	}
}
