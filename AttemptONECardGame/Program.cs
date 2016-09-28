using System;

namespace AttemptONECardGame
{
	class MainClass
	{


		public static void Main(string[] args)
		{
			Greeting();
			Card obj = new Card();

			Console.WriteLine("Rank:" + obj.GetSuit() + " Suite:" + obj.GetRank() + "Object To String " + obj.ToString());


			Console.WriteLine("End!!!");

		}
		public static void Greeting()
		{
			Console.WriteLine("Hello, welcome to Blackjack!!!");

		}
	}
}
