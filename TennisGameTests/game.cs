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

        private Boolean bothPlayerScoredMoreThanThreePoints() {

            return player1.score >= 3 && player2.score >= 3;

        }

        private Boolean isDeuce()
        {
            return player1.score == player2.score;
        }

        private Boolean isAdvantage()
        {
            return Math.Abs(player1.score - player2.score) < 2
                && player1.score != player2.score;
        }

        private string checkWinnerAfterDeuce()
        {
            if (isDeuce() || isAdvantage())
                return "still playing";

            else if (player1.score > player2.score)
                return "player1";
            else
                return "player2";
        }

        private string checkWinnerWhenNoDeuce()
        {
            if (player1.score > 3)
                return "player1";
            else if (player2.score > 3)
                return "player2";
            else
                return "still playing";
        }
        public string getWinner()
        {
            if (bothPlayerScoredMoreThanThreePoints())
            {
                return checkWinnerAfterDeuce();
            }
            else
                return checkWinnerWhenNoDeuce();
           
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
