using System;

namespace AttemptONECardGame
{
	class MainClass
	{


		public static void Main(string[] args)
		{
			Greeting();
			Card obj = new Card();

			Console.WriteLine(obj.getRank().GetType() + " " + obj.theSuit);




			Console.WriteLine("End!!!");

		}
		public static void Greeting()
		{
			Console.WriteLine("Hello, welcome to Blackjack!!!");

		}
	}
}
