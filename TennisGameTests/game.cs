using System;
namespace TennisGame
{
    public class Game
    {
        private Player player1;
        private Player player2;

        public Game()
        {
            player1 = new Player();
            player2 = new Player();
            player1.name = "player1";
            player1.score = 0;
            player2.name = "player2";
            player2.score = 0;

        }

        public string getWinner()
        {
            if (player1.score > 3)
                return "player1";
            else if (player2.score > 3)
                return "player2";
            else
                return "still playing";
        }

        public void addPoint(string playerName)
        {
            if (playerName == "player1")
            {
                player1.score++;
            }
            else if (playerName == "player2")
            {
                player2.score++;
            }
        }
    }
}
