using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors {
	// This will be a chance for me to practice using OOP
	// and other constructs in C#.
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Epic game!");
			
			// Creating objects of the player class:
			Player player1 = new Player();
			Player player2 = new Player();

			player1.HandSelector();
			player2.HandSelector();

		}
	}

	
	class Player {
		private string playerName;
		private int points = 0;
		public int CurrentPoints { get; set; }
		
		private string hand;
		
		public override string ToString() {
			return "playerName = " + playerName + "hand = " + hand + "points = " + points;
			}
		
		public Player() {
			Console.Write("What is your name? ");
			playerName = Console.ReadLine();
			Console.WriteLine("{0} has joined the game!", playerName);
		}
		
		public string HandSelector() {
			Console.WriteLine(playerName);
			while (!(hand == "rock" || hand == "paper" || hand == "scissors")) {
				Console.Write("Select rock, paper or scissors: ");
				hand = Console.ReadLine();
				
			}
			return hand;
		}
	}
	
}

